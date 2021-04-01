using System;

namespace TianYanCha.SDK.Extensions
{
    public static class LongExtensions
    {
        public static string ToDateTime(this long? @long)
        {
            if (!@long.HasValue)
                return string.Empty;
            var datetime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var ticks = datetime.Ticks + @long.Value * 10000;
            return new DateTime(ticks).ToString("yyyy-MM-dd HH-mm-ss");
        }
    }
}
