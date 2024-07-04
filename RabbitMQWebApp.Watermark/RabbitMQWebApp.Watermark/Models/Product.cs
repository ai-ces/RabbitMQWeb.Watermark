using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RabbitMQWebApp.Watermark.Models
{
    public class Product
    {
        [Key]
        public int id {  get; set; }
        public int Id { get; internal set; }
        [StringLength(100)]
        public string name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal price { get; set; }

        [Range(1, 100)]
        public int Stock {  get; set; }

        [StringLength(100)]
        public string PictureUrl { get; set; }
    }
}
