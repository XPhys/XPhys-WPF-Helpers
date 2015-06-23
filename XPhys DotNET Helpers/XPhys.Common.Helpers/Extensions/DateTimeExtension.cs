using System;

namespace XPhys.Common.Helpers.Extensions
{
    public static class DateTimeExtension
    {
        /// <summary>
        /// OBJECTIVE: To trim System.DateTime ignored millisec
        /// FORMAT: 'yyyy-HH-dd HH:mm:ss'
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime TrimMilliseconds(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0);
        }
    }
}
