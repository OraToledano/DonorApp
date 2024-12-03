using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonorApp.Models
{
    public class Address
    {
        [Required(ErrorMessage = "עיר היא שדה חובה")]
        [StringLength(100, ErrorMessage = "שם העיר לא יכול להיות ארוך מ-100 תווים")]
        public string City { get; set; } // עיר

        [Required(ErrorMessage = "רחוב הוא שדה חובה")]
        [StringLength(100, ErrorMessage = "שם הרחוב לא יכול להיות ארוך מ-100 תווים")]
        public string Street { get; set; } // רחוב

        [Required(ErrorMessage = "מיקוד הוא שדה חובה")]
        [StringLength(10, ErrorMessage = "מיקוד לא יכול להיות ארוך מ-10 תווים")]
        public string ZipCode { get; set; } // מיקוד

        [Range(1, int.MaxValue, ErrorMessage = "מספר בית חייב להיות חיובי")]
        public int HouseNumber { get; set; } // מספר בית
    }
}
