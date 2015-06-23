using System;

namespace XPhys.Common.Helpers
{
    public class AnonymousCast
    {
        /// <summary>
        /// OBJECTIVE: To cast anonymous object 
        /// </summary>
        /// <typeparam name="T">Target Type</typeparam>
        /// <param name="typeHolder">Example of target instance. Just new() object</param>
        /// <param name="x">Anonymouse object</param>
        /// <returns></returns>
        public static T Cast<T>(T typeHolder, Object x)
        {
            // typeHolder above is just for compiler magic
            // to infer the type to cast x to
            return (T)x;
        }
    }
}
