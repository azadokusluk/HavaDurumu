using HavaDurumuUygulaması.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HavaDurumuUygulaması.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HavaDurumu()
        {
            ViewBag.Message = "Hava Durumu Uygulaması";
            HavaDurumu h = HavaDurumuGetir();

            return View(h);
        }
        public HavaDurumu HavaDurumuGetir()
        {
            var client = new RestClient("https://api.collectapi.com/weather/getWeather?data.lang=tr&data.city=ankara"); //city= kısmına başka bir şehir yazılabilir.
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "apikey 6CnoEMqMXemR5NIZVd13gF:3YOP8OzqTdEHRhyLBtG76c");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);

            HavaDurumu hava = JsonConvert.DeserializeObject<HavaDurumu>(response.Content);


            return hava;
        }


    }
}