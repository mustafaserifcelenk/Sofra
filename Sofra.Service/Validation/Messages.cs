namespace Sofra.Service.Validation
{
    public class Messages
    {
        public static class Reservation
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir rezervasyon bulunamadı.";
                return "Böyle bir rezervasyon bulunamadı.";
            }

            public static string Add(DateTime tarih)
            {
                return $"{tarih:G} tarihli rezervasyon başarıyla eklenmiştir.";
            }
        }
    }
}
