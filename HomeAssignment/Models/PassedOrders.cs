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
        

        
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Order Number")]
        public int Id { get; set; }
        [DisplayName("Order Name")]
        public string OrderName { get; set; }
        [DisplayName("Order Status")]
        public string OrderStatus { get; set; }
        [DisplayName("Order Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        [DataType(DataType.Date)]
        public DateTime DateOfOrder { get; set; }
        [DisplayName("Total Wight")]
        public float TotalWight { get; set; }
        [DisplayName("Est Suppling Date")]
        public DateTime EstimatedSupplingDate { get; set; }

    }
}
