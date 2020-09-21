using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstAPIExampleProject.Models;

namespace FirstAPIExampleProject.Controllers
{
    public class LoginController : ApiController
    {
        NorthwindEntities entities = new NorthwindEntities();
        [HttpPost]
        public string CheckLogin(user user)
        {
            try
            {
                user chkUser = entities.users.Where(u => u.id == user.id && u.password == user.password).First();
                return chkUser.id.ToString();
            }
            catch (Exception)
            {

                return null;
            }
        }
        [HttpGet]
        public List<Product> GetProductByPrice(int price)
        {
            List<Product> products = entities.Products.Where(p => p.UnitPrice < price).ToList();
            return products;
        }
    }
}
