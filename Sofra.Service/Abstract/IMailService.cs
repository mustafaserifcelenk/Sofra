using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sofra.Service.Abstract
{
    public interface IMailService
    {
        Task SendMail(string to, DateTime date);
    }
}
