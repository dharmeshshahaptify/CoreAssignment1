using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assginment1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assginment1.Controllers
{
    public class AccountController : Controller
    {

        public List<City> lstCities = new List<City>()
        {
            new City() { CityId = 1, CityName = "Pune", CountryId = 2 },
            new City() { CityId = 2, CityName = "Noida", CountryId = 2 },
            new City() { CityId = 3, CityName = "Chicago", CountryId = 1 },
            new City() { CityId = 4, CityName = "Sacremento", CountryId = 1 },

        };


        public List<Country> lstCountires = new List<Country>()
        {
            new Country() { CountryId = 1, CountryName = "USA" },
            new Country() {  CountryId = 2, CountryName = "India" }


        };

        public IActionResult SignUp()
        {

            UserModel model = new UserModel();
            //model.Countries = new SelectList(lstCountires, "CountryId", "CountryName"); ;
            model.CountryList = lstCountires;
           // ViewBag.CountryList = new SelectList(lstCountires, "CountryId", "CountryName");
            return View();
        }

    

        [HttpPost]
        public IActionResult SignUp(UserModel model) //model binding
        {
            //if(string.IsNullOrEmpty(model.Name))
            //{
            //    ModelState.AddModelError("Name", "Please Enter Name");
            //}
            //if (string.IsNullOrEmpty(model.Username))
            //{
            //    ModelState.AddModelError("Username", "Please Enter Username");
            //}



            if (ModelState.IsValid)
            {
                // TO Do:
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


      

    



    }
}
