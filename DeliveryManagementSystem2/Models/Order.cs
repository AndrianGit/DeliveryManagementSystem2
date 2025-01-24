using System.ComponentModel.DataAnnotations;

namespace DeliveryManagementSystem2.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string OrderNumber { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public string OrderStatus { get; set; }

        [Required]
        public string DeliveryAddress { get; set; }
    }
}