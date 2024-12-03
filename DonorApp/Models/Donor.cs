using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonorApp.Models
{
    public enum Title
    {   Madame
        ,Monsieur
        ,Mademoiselle,
        Other
    }
    public class Donor
    {
        [Key] // ציון שדה המפתח הראשי
        public int DonorId { get; set; } // מפתח ראשי

        [Required(ErrorMessage = "שם פרטי הוא שדה חובה")]
        [StringLength(100, ErrorMessage = "שם פרטי לא יכול להיות ארוך מ-100 תווים")]
        public string FirstName { get; set; } // שם פרטי

        [Required(ErrorMessage = "שם משפחה הוא שדה חובה")]
        [StringLength(100, ErrorMessage = "שם משפחה לא יכול להיות ארוך מ-100 תווים")]
        public string LastName { get; set; } // שם משפחה

        [EmailAddress(ErrorMessage = "מייל לא תקין")]
        public string Email { get; set; } // מייל

        public Title Title { get; set; } // מגדר

        public Address Address { get; set; } // כתובת

        
    }
}
