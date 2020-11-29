﻿using HomeAssignment.Models;
using HomeAssignment.Models.VMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssignment
{
    public partial class FormNewOrder : Form
    {
        public FormNewOrder()
        {
            InitializeComponent();
        }

        public bool IsNew = false;
        public Order passedOrder = null;
        public FormOrders FrmOrder = null;

        private void FormNewOrder_Load(object sender, EventArgs e)
        {
            if (IsNew)
            {
                dataGridNewOrders.Visible = false;
                //panelMainContainer.Enabled = false;
                MakeFormEnable(false);
            }
            else
            {
                GenerateData();
                dataGridNewOrders.Visible = true;
                MakeFormEnable(true);
                LoadOrderExistingData();
            }
        }

        private void LoadOrderExistingData()
        {
            if (passedOrder != null)
            {
                txtOrderId.Text = passedOrder.Id.ToString();
                txtOrderName.Text = passedOrder.OrderName;
                DropDownOrderStatus.SelectedItem = passedOrder.OrderStatus;
                txtTotalWeight.Text = passedOrder.TotalWight.ToString();
                dtEstDataOfSupply.Value = passedOrder.EstimatedSupplingDate;
                dtDateOfOrder.Value = passedOrder.DateOfOrder;

            }
        
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

            var sketch = new NewOrderSketchVM();
            sketch.Lines = new List<NewOrderSketchLineVM>();

            sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(16, 2));
            sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(16, 16));
            sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(38, 16));
            sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(16, 5));

            row.Sketch = sketch;
            
            lstData.Add(row);

            row= new NewOrderVM();

            row.Amount = 11;
            row.Diameter = 3;
            row.RawNumber = 1;
            row.TotalLength = 20;
            row.Weight = 75;

            sketch = new NewOrderSketchVM();
            sketch.Lines = new List<NewOrderSketchLineVM>();

            sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(48, 2));
            sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(16, 2));
            sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(16, 16));
            sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(48, 16));

            row.Sketch = sketch;

            lstData.Add(row);

            row = new NewOrderVM();

            row.Amount = 9;
            row.Diameter = 3;
            row.RawNumber = 1;
            row.TotalLength = 30;
            row.Weight = 85;

            sketch = new NewOrderSketchVM();
            sketch.Lines = new List<NewOrderSketchLineVM>();
            sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(48, 2));
            sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(16, 10));
            sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(16, 16));
            sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(48, 16));

            row.Sketch = sketch;


            lstData.Add(row);

            dataGridNewOrders.DataSource = lstData;


        }

        private void dataGridNewOrders_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                
                using (Brush gridBrush = new SolidBrush(this.dataGridNewOrders.GridColor), backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {

                    using (Pen gridLinePen = new Pen(gridBrush))
                    { 
                        // Erase the cell.
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                        // Draw the grid lines (only the right and bottom lines;
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,e.CellBounds.Top, e.CellBounds.Right - 1,e.CellBounds.Bottom);

                    }

                }

                using (Brush gridBrush = new SolidBrush(Color.Black),  backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    using (Pen gridLinePen = new Pen(gridBrush))
                    {
                        if (e.Value != null && e.Value.GetType() == typeof(NewOrderSketchVM))
                        {
                            var lstLines = (NewOrderSketchVM)e.Value;

                            if (lstLines != null && lstLines.Lines != null && lstLines.Lines.Count > 0)
                            {
                                float currentX = -1;
                                float currentY = -1;

                                foreach (var line in lstLines.Lines)
                                {
                                    if (currentX == -1 && currentY == -1)
                                    {
                                        currentX = e.CellBounds.Left + 2 + line.LengthX;
                                        currentY = e.CellBounds.Top + 2 + line.LengthY;
                                    }
                                    else
                                    {
                                        float tempNextX = e.CellBounds.Left + 2 + line.LengthX;
                                        float tempNextY = e.CellBounds.Top + 2 + line.LengthY;


                                        e.Graphics.DrawLine(gridLinePen, currentX, currentY, tempNextX, tempNextY);

                                        float sDrawX = 0;
                                        float sDrawY = 0;
                                        float sLenght = 0;

                                        if (currentX == tempNextX)
                                        {
                                            sDrawX = currentX - 2;
                                            sDrawY = ((currentY + tempNextY) / 2) - 4;
                                        }
                                        else if (currentY == tempNextY)
                                        {
                                            sDrawX = currentX - 2;
                                            sDrawY = ((currentY + tempNextY) / 2) -4;
                                        }
                                        else
                                        {
                                            sDrawX = currentX - 4;
                                            sDrawY = currentY  - 4;

                                        }

                                        sLenght = Math.Abs((tempNextX - currentX) + (tempNextY - currentY));

                                        e.Graphics.DrawString(sLenght.ToString() , new Font(FontFamily.GenericSansSerif, 5), Brushes.Crimson, sDrawX, sDrawY, StringFormat.GenericDefault);


                                        currentX = tempNextX;
                                        currentY = tempNextY;

                                        


                                    }
                                }
                            }
                        }
                        e.Handled = true;

                    }
                }
            }

        
        }

        private void btnUploadPDF_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {


                dlg.Filter = "PDF Files (*.pdf)|*.pdf";



                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    lblPDFFileName.Text = "File Name: " + dlg.FileName;


                    if (IsNew)
                    {
                        GenerateData();
                        dataGridNewOrders.Visible = true;
                        panelMainContainer.Enabled = true;
                    }
                    
                }



            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ChangeResultText("", Color.Black);
            MakeFormEnable(false);
            if (!validateInputs())
            {
                MakeFormEnable(true);
                return;
            }

            int existingOrderId = 0;

            if (!IsNew)
            {
                int.TryParse(txtOrderId.Text.Trim(), out existingOrderId);
            }
            var task = Task.Factory.StartNew(() => SaveOrderData(existingOrderId));


            
        }


        public async Task SaveOrderData(int existingOrderId)
        {
            try
            {

                float weight = 0;

                ChangeResultText("Saving order please wait", Color.Black);

                if (!float.TryParse(txtTotalWeight.Text.Trim(), out weight))
                {
                    ChangeResultText("Please enter valid Total Weight", Color.Red);
                    MakeFormEnable(false);
                }


                using (var dbx = new AppDBContext())
                {
                    Order order = null;
                                        
                    if (existingOrderId > 0)
                    {
                        order = dbx.Orders.Where(x => x.Id == existingOrderId).FirstOrDefault();
                    }

                    if (order == null)
                    {
                        order = new Order();
                        dbx.Orders.Add(order);

                        if (existingOrderId > 0)
                        {
                            order.Id = existingOrderId;
                        }
                    }

                    order.OrderName = txtOrderName.Text.Trim();
                    DropDownOrderStatus.BeginInvoke((Action)(() => {
                        order.OrderStatus = (string)DropDownOrderStatus.Items[DropDownOrderStatus.SelectedIndex];
                    }));
                    
                    order.TotalWight = weight;
                    order.EstimatedSupplingDate = dtEstDataOfSupply.Value;
                    order.DateOfOrder = dtDateOfOrder.Value;
                    dbx.SaveChanges();

                    MakeFormEnable(true);

                    this.BeginInvoke((Action)(() => {
                        FrmOrder.dataChangedFromNewOrder = true;
                        this.Close();
                    }));
                    

                }
            }
            catch (Exception ex)
            {
                MakeFormEnable(true);
                ChangeResultText("There was an error while saving the order", Color.Red);
            }


        }




        private bool validateInputs()
        {
            if (txtOrderName.Text == "")
            {
                ChangeResultText("Please enter the Order Name", Color.Red);
                return false;
            }

            if (txtTotalWeight.Text == "")
            {
                ChangeResultText("Please enter the Total Weight", Color.Red);
                return false;
            }

            if (txtTotalWeight.Text.Trim() == "")
            {
                ChangeResultText("Please enter the Total Weight", Color.Red);
                return false;
            }


            if (DropDownOrderStatus.SelectedIndex < 0)
            {
                ChangeResultText("Please select Order Status", Color.Red);
                return false;
            }



            return true;

        }

        public void ChangeResultText(string strMsg, Color color)
        {
            lblResult.BeginInvoke((Action)(() => {
                lblResult.Text = strMsg;
                lblResult.ForeColor = color;
            }));

        }

        public void MakeFormEnable(bool enableForm)
        {
            panelMainContainer.BeginInvoke((Action)(() => {
                panelMainContainer.Enabled = enableForm;
            }));

        }
    }
}
