using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dependency_injection
{
    public class NumGenerator: INumGenerator
    {

        public int GetRandomNumber()
        {
            return new Random().Next(1000);
        }
    }

    public interface INumGenerator
    {
        public int GetRandomNumber();
    }
}
