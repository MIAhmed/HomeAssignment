using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HomeAssignment.Models.VMs
{
    public class NewOrderVM
    {

        public float Weight { get; set; }
        public NewOrderSketchVM Sketch { get; set; }
        [DisplayName("Total Length")]
        public float TotalLength { get; set; }
        public float Amount { get; set; }
        public float Diameter { get; set; }

        [DisplayName("Raw Number")]
        public int RawNumber { get; set; }
        
        

        
        
        

    }


    public class NewOrderSketchVM
    {
        public List<NewOrderSketchLineVM> Lines { get; set; }

    }


    public class NewOrderSketchLineVM
    {
        public float LengthX { get; set; }
        public float LengthY { get; set; }
  
    }


}
