using Microsoft.AspNetCore.Mvc;
using OfisVeriAlma.Models;
using System.Security.Cryptography.X509Certificates;

namespace OfisVeriAlma.Controllers
{
    public class QueryController : Controller
    {
        
        public IActionResult QueryStringVeri(User user)
        {
            var qs1 = Request.QueryString;//string olarak getirir
            var qs2 = Request.Query["İsim"];// keye göre value alır

            List<string> qsList = new List<string>();

            foreach (var item in Request.Query.Keys)
            {
                qsList.Add(Request.Query[item]);

            }


            return View();

        }
        public IActionResult RouteValues()
        {
            var rv = Request.RouteValues;
             return View();
        }
        public IActionResult HeaderValues()
        {
            var hv = Request.Headers;
            var hv1 = Request.Headers["il"];


            foreach (var item in hv)
            {

            }


            return View();

        }

        


    }

   
}
