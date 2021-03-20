using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scoped
{
    public class NumGenerator2: INumGenerator2
    {
        public int RandomValue { get;  }
        public NumGenerator2()
        {
            RandomValue = new Random().Next(1000);
        }
    }

    public interface INumGenerator2
    {

        public int RandomValue { get; }
    }
}
