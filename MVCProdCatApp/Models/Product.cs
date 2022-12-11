using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProdCatApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        
        [Range(1, int.MaxValue)]
        public double Price { get; set; }
        [ValidateNever]
        public string Image { get; set; }
        
        [Display(Name = "Category Type")]
        public int CategoryId { get; set; }
        
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public virtual Category Category { get; set; }

    }
}
