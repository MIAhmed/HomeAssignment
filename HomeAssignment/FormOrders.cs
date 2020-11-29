using HomeAssignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public bool dataChangedFromNewOrder = false;

        private void GenerateData() 
        {

            try
            {
                List<Order> lstOrders = new List<Order>();
                using (var dbx = new AppDBContext())
                {
                    lstOrders = dbx.Orders.Select(x => x).ToList();


                    if (lstOrders == null || lstOrders.Count < 1)
                    {
                        lstOrders = new List<Order>();
                        lstOrders.Add(new Order { Id = 1, DateOfOrder = DateTime.Now, EstimatedSupplingDate = DateTime.Now.AddDays(2), OrderName = "First Order", OrderStatus = "In progress", TotalWight = 25 });
                        lstOrders.Add(new Order { Id = 2, DateOfOrder = DateTime.Now, EstimatedSupplingDate = DateTime.Now.AddDays(-3), OrderName = "Another Order", OrderStatus = "In progress", TotalWight = 25 });
                        dbx.Orders.AddRange(lstOrders);
                        dbx.SaveChanges();
                        lstOrders = dbx.Orders.Select(x => x).ToList();
                    }

                    

                }


                dataGridOrders.DataSource = lstOrders;

                //3 5
                dataGridOrders.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridOrders.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";

            }
            catch (Exception ex)
            {

                MessageBox.Show("There was an error while loading data");
            }

        }

        private void dataGridOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataChangedFromNewOrder = false;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                var data = (Order)dataGridOrders.Rows[e.RowIndex].DataBoundItem;


                var frmOrder = new FormNewOrder();
                frmOrder.passedOrder = data;
                frmOrder.FrmOrder = this;
                frmOrder.IsNew = false;
                frmOrder.ShowDialog();
                if (dataChangedFromNewOrder)
                {
                    GenerateData();
                }

            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            dataChangedFromNewOrder = false;
            var frmOrder = new FormNewOrder();
            frmOrder.FrmOrder = this;
            frmOrder.IsNew = true;
            frmOrder.ShowDialog();
            if (dataChangedFromNewOrder)
            {
                GenerateData();
            }

        }
    }
}
