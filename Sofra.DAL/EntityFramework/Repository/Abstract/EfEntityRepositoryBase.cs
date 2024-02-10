﻿using LinqKit;
using Microsoft.EntityFrameworkCore;
using Sofra.DAL.EntityFramework.Repository.Abstract;
using Sofra.Data.Entity;
using System.Linq.Expressions;

public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
{
    protected readonly DbContext _context;

    public EfEntityRepositoryBase(DbContext context)
    {
        _context = context;
    }

    public async Task<TEntity> AddAsync(TEntity entity) // ajax için ekleme buraya, return değeri ekledik (IEntityRepository)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        return entity;
    }

    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _context.Set<TEntity>().AnyAsync(predicate);
    }

    public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null)
    {
        return await (predicate == null ? _context.Set<TEntity>().CountAsync() : _context.Set<TEntity>().CountAsync(predicate));
    }

    public async Task DeleteAsync(TEntity entity)
    {
        await Task.Run(() => { _context.Set<TEntity>().Remove(entity); }); //Remove'un async'i yok kendimiz oluşturduk
    }

    public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        //Burada yapacağımız işleri include propertiesde de kullanacağımız için abonelik işlemi yapıyoruz
        IQueryable<TEntity> query = _context.Set<TEntity>();
        if (predicate != null)
        {
            query = query.Where(predicate);
        }

        if (includeProperties.Any())
        {
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty); // Her gelen include için teker teker ekleme işlemi yapılacak
            }
        }

        return await query.AsNoTracking().ToListAsync();
    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();
        query = query.Where(predicate);

        if (includeProperties.Any())
        {
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty); //Her gelen include için teker teker ekleme işlemi yapılacak
            }
        }

        return await query.AsNoTracking().SingleOrDefaultAsync();
    }

    public async Task<IList<TEntity>> SearchAsync(IList<Expression<Func<TEntity, bool>>> predicates, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();
        // Liste aldığımız için bu listenin içi boş olsa bile null olmayabilir, boş liste gelebilir, o yüzden any kontrolü yapıyoruz
        if (predicates.Any())
        {
            // predicate1 && predicate2 && predicate3 ... bunlar birbirlerine and ile ekleniyor, biz bunları veya ile eklemek istiyoruz
            var predicateChain = PredicateBuilder.New<TEntity>();
            foreach (var predicate in predicates)
            {
                predicateChain.Or(predicate);
            }
            query = query.Where(predicateChain);
        }
        if (includeProperties.Any())
        {
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
        }
        // Sonsuz loopa girmeyi engeller
        return await query.AsNoTracking().ToListAsync();
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
        return entity;
    }
}
