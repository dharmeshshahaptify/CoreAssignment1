using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Assginment1.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assginment1.Models
{
    public class UserModel
    {

        [Required(ErrorMessage = "Please Enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm Password doesn't match")]
        public string ConfirmPassword { get; set; }

        [RegularExpression("^[6,7,8,9]\\d{9}$", ErrorMessage = "Please Enter Correct Contact No.")]
        public string Contact { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool Terms { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; }
        public List<Country> CountryList { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City{ get; set; }
        public SelectList Cities { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }


    }

    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }

    public class City
    {

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }

    }


}
