using homework_v1.Data;
using homework_v1.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_v1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        [Route("GetAllProducts")]
        [HttpGet, HttpOptions]
        public List<ProductModel> GetAllProducts()
        {
            var productList = DummyData.Instance.Products;

            return productList;
        }

        [Route("Add")]
        [HttpPost]
        public List<ProductModel> Add([FromBody] ProductModel productModel)
        {
            var productList = DummyData.Instance.Products;
            productList.Add(productModel);

            return productList;
        }

        [Route("Edit")]
        [HttpPut, HttpOptions]
        public List<ProductModel> Edit([FromBody] ProductModel productModel)
        {
            var productList = DummyData.Instance.Products;
            var index = productList.FindIndex(c => c.Id == productModel.Id);
            productList[index] = productModel;

            return productList;
        }

    }
}
