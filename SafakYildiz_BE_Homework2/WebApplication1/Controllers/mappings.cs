using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class mappings
    {
        
        public class CarModel
        {
            public int Id
            {
                get; set;
            }
            public string FirstName
            {
                get; set;
            }
            public string LastName
            {
                get; set;
            }
            public string Address
            {
                get; set;
            }
        }

        public class CarDTO
        {
            public int Id
            {
                get; set;
            }
            public string FirstName
            {
                get; set;
            }
            public string LastName
            {
                get; set;
            }
            public string Address
            {
                get; set;
            }
            
            }
  



    }
}
