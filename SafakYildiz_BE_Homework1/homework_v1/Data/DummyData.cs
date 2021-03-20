using homework_v1.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace homework_v1.Data
{
    public class DummyData
    {
        public List<ProductModel> Products = new List<ProductModel>();
        private static DummyData _instance = null;


        public static DummyData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DummyData();
                }
                return _instance;
            }
        }

        private DummyData()
        {
            FillData();
        }

        private void FillData()
        {
            for (int i = 1; i <= 10; i++)
            {
                Products.Add(new ProductModel { Id = i, Name = "Product_" + i, Price = 100 + (i * 10) });
            }
        }

    }

}
