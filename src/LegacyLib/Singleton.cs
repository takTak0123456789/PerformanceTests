using System;

namespace LegacyLib
{
    public class Singleton<T> where T : class, new()
    {
        private static readonly Lazy<T> LazyInstance = new Lazy<T>(() => new T());

        protected Singleton()
        {
        }



        public static T Instance
        {
            get
            {
                return LazyInstance.Value;
            }
        }
    }

}
