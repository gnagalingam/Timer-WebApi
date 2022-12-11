using System.ComponentModel.DataAnnotations;

namespace InventoryApi.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }  

        public string? Description { get; set; }

        public int count { get; set; }

    }
}
