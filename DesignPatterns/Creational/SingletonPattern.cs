using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class SingletonPattern
    {
        private static SingletonPattern singletonObject;
        private static readonly object lockObject = new object();
        private SingletonPattern()
        { }
        public static SingletonPattern CreateSingletonObject()
        {
            if (singletonObject == null)
            {
                lock (lockObject)
                { 
                    if (singletonObject == null)
                        singletonObject = new SingletonPattern();
                }
            }
                
            return singletonObject;
        }
    }
}
