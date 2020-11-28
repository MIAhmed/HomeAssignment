using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeAssignment.Models
{
    public class PassedOrders
    {
        

        public DateTime EstimatedSupplingDate { get; set; }
        public float TotalWight { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string OrderStatus { get; set; }
        public string OrderName { get; set; }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Order Number")]
        public int Id { get; set; }
        
    
    }
}
