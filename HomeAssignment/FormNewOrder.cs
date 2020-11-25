using HomeAssignment.Models.VMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HomeAssignment
{
    public partial class FormNewOrder : Form
    {
        public FormNewOrder()
        {
            InitializeComponent();
        }

        private void FormNewOrder_Load(object sender, EventArgs e)
        {
            GenerateData();
        }



        private void GenerateData()
        {
            var lstData = new List<NewOrderVM>();

            NewOrderVM row = new NewOrderVM();

            row.Amount = 10;
            row.Diameter = 2;
            row.RawNumber = 1;
            row.TotalLength = 25;
            row.Weight = 65;

            lstData.Add(row);

            row.Amount = 11;
            row.Diameter = 3;
            row.RawNumber = 1;
            row.TotalLength = 20;
            row.Weight = 75;

            lstData.Add(row);


            row.Amount = 9;
            row.Diameter = 3;
            row.RawNumber = 1;
            row.TotalLength = 25;
            row.Weight = 85;

            lstData.Add(row);

            dataGridNewOrders.DataSource = lstData;

            


            //DataGridViewColum


        }

        private void dataGridNewOrders_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (this.dataGridNewOrders.CurrentCell .RowIndex == e.RowIndex && this.dataGridNewOrders.CurrentCell.ColumnIndex == e.ColumnIndex)
                if (e.ColumnIndex == 1 && e.RowIndex != -1)// this.dataGridNewOrders.CurrentCell.RowIndex == e.RowIndex && this.dataGridNewOrders.CurrentCell.ColumnIndex == e.ColumnIndex)

                {

                Rectangle newRect = new Rectangle(e.CellBounds.X + 1,

                    e.CellBounds.Y + 1, e.CellBounds.Width - 4,

                    e.CellBounds.Height - 4);



                using (

                    Brush gridBrush = new SolidBrush(this.dataGridNewOrders.GridColor),

                    backColorBrush = new SolidBrush(e.CellStyle.BackColor))

                {

                    using (Pen gridLinePen = new Pen(gridBrush))

                    {

                        // Erase the cell.

                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);



                        // Draw the grid lines (only the right and bottom lines;

                        // DataGridView takes care of the others).

                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,

                            e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,

                            e.CellBounds.Bottom - 1);

                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,

                            e.CellBounds.Top, e.CellBounds.Right - 1,

                            e.CellBounds.Bottom);



                        // Draw the inset highlight box.

                        e.Graphics.DrawEllipse(Pens.Blue, newRect);





                        // Draw the text content of the cell, ignoring alignment.

                        //if (e.Value != null)

                        //{

                        //    e.Graphics.DrawString((String)e.Value, e.CellStyle.Font,

                        //        Brushes.Crimson, e.CellBounds.X + 2,

                        //        e.CellBounds.Y + 2, StringFormat.GenericDefault);

                        //}

                        e.Handled = true;

                    }

                }

            }

        
    }
    }
}
