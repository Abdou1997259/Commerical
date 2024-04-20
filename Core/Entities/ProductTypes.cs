using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class ProductTypes
    {
        public int Id {get;set;} 
        [Required]
        public string Name{get;set;}=null!;
        
    }
}