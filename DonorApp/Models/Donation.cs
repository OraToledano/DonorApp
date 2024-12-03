using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonorApp.Models
{

    public enum Organization
    {
        Kol_yosseph,
        Or_yosseph

    }
    public enum PaymentMethod
    {
        BankTransfer,  
        BankCheque 
    }

    public class Donation
     {
       
        [Key] // ציון שדה המפתח הראשי
        public int DonationId { get; set; } // מפתח ראשי

        [Required(ErrorMessage = "העמותה היא שדה חובה")]
        public Organization Organization { get; set; } // עמותה

        [Required(ErrorMessage = "אסמכתא היא שדה חובה")]
        [StringLength(50, ErrorMessage = "אסמכתא לא יכולה להיות ארוכה מ-50 תווים")]
        public string ReferenceNumber { get; set; } // אסמכתא - מספר עוקב

        [Range(0.01, double.MaxValue, ErrorMessage = "סכום חייב להיות חיובי")]
        public decimal Amount { get; set; } // סכום במספרים

        [Required(ErrorMessage = "סכום באותיות הוא שדה חובה")]
        public string AmountInWords { get; set; } // סכום באותיות

        [Required(ErrorMessage = "תאריך התרומה הוא שדה חובה")]
        public DateTime DonationDate { get; set; } // תאריך התרומה

        [Required(ErrorMessage = "תאריך הנפקת הקבלה הוא שדה חובה")]
        public DateTime ReceiptDate { get; set; } // תאריך הנפקת הקבלה

        [Required(ErrorMessage = "דרך התרומה היא שדה חובה")]
        public PaymentMethod PaymentMethod { get; set; } // דרך התרומה (צ'ק בנקאי, העברה וכו')

        [ForeignKey("Donor")] // ציון מפתח זר
        public int DonorId { get; set; } // מפתח זר לתורם
        
    }
}
