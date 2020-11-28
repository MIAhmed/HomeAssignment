using HomeAssignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeAssignment
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            GenerateData();
        }



        private void GenerateData() 
        {

            List<PassedOrders> lstOrders = new List<PassedOrders>();
            lstOrders.Add( new PassedOrders{ DateOfOrder = DateTime.Now, EstimatedSupplingDate = DateTime.Now.AddDays(2), OrderName = "First Order", OrderStatus = "In progress", TotalWight = 25 });

            dataGridOrders.DataSource = lstOrders;

        
        }
    }
}
