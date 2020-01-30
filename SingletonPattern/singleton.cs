using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class singleton
    {
        private static singleton instance;

        public string Name { get; set; }

        public static singleton getInstance()
        {
            if (instance == null)
            {
                instance = new singleton();
                instance.Name = "Singleton";
            }

            return instance;

        }


    }
}
