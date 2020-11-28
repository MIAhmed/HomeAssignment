using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HomeAssignment.Models.VMs
{
    public class NewOrderVM
    {

        [DisplayName("Raw Number")]
        public int RawNumber { get; set; }
        
        public float Diameter { get; set; }

        public float Amount { get; set; }
        [DisplayName("Total Length")]
        public float TotalLength { get; set; }
        public NewOrderSketchVM Sketch { get; set; }
        public float Weight { get; set; }
    }


    public class NewOrderSketchVM
    {
        public List<NewOrderSketchLineVM> Lines { get; set; }

    }


    public class NewOrderSketchLineVM
    {
        public float LengthX { get; set; }
        public float LengthY { get; set; }

        public float Diminution { get; set; }

        public NewOrderSketchLineVM SeLine(float x, float y)
        {
            this.LengthX = x;
            this.LengthY = y;

            return this;
        }

    }


}
