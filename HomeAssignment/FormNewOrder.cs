using HomeAssignment.Models;
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

        List<NewOrderVM> lstData = new List<NewOrderVM>();


        private void FormNewOrder_Load(object sender, EventArgs e)
        {

            dataGridNewOrders.RowTemplate.Height = 50;
            if (IsNew)
            {
                dataGridNewOrders.Visible = false;
                //panelMainContainer.Enabled = false;
                MakeFormEnable(false);
            }
            else
            {
                
                dataGridNewOrders.Visible = true;
                MakeFormEnable(true);
                LoadOrderExistingData();
                GenerateData();
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

            //lstData = new List<NewOrderVM>();
            dataGridNewOrders.DataSource = null;
            if (lstData.Count == 0)
            {

                NewOrderVM row = new NewOrderVM();

                row.Amount = 10;
                row.Diameter = 2;
                row.RawNumber = 1;
                //row.Weight = 65;

                var sketch = new NewOrderSketchVM();
                sketch.Lines = new List<NewOrderSketchLineVM>();

                sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(36, 10));
                sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(36, 36));
                sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(78, 36));
                sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(36, 10));

                row.TotalLength = CalculatLengthForEachLine(sketch.Lines);


                row.Sketch = sketch;

                lstData.Add(row);

                row = new NewOrderVM();

                row.Amount = 11;
                row.Diameter = 3;
                row.RawNumber = 1;
                //row.Weight = 20;


                sketch = new NewOrderSketchVM();
                sketch.Lines = new List<NewOrderSketchLineVM>();

                sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(78, 12));
                sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(36, 12));
                sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(36, 36));
                sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(78, 36));
                row.Sketch = sketch;

                row.TotalLength = CalculatLengthForEachLine(sketch.Lines);


                lstData.Add(row);

                row = new NewOrderVM();

                row.Amount = 9;
                row.Diameter = 3;
                row.RawNumber = 1;
                //row.Weight = 85;

                sketch = new NewOrderSketchVM();
                sketch.Lines = new List<NewOrderSketchLineVM>();
                sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(78, 12));
                sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(36, 20));
                sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(36, 36));
                sketch.Lines.Add(new NewOrderSketchLineVM().SeLine(78, 36));

                row.TotalLength = CalculatLengthForEachLine(sketch.Lines);

                row.Sketch = sketch;


                lstData.Add(row);

            }
            else
            {
                foreach (var row in lstData)
                {
                    row.TotalLength = CalculatLengthForEachLine(row.Sketch.Lines);


                }
                CalculatWeigthForEachRow(lstData);
            }

            
            dataGridNewOrders.DataSource = lstData;

            dataGridNewOrders.Columns[5].DefaultCellStyle.Format = "0.0000##";


        }



        private float CalculatLengthForEachLine(List<NewOrderSketchLineVM> lstLines)
        {
            float totalLenght = 0;

            for (int i =0; i < lstLines.Count;  i++)
            {
                if (i > 0 && lstLines[i].Diminution < 1)
                {
                    lstLines[i].Diminution = Math.Abs((lstLines[i - 1].LengthX - lstLines[i].LengthX) + (lstLines[i - 1].LengthY - lstLines[i].LengthY));
                }

                totalLenght += lstLines[i].Diminution;
            }
            return totalLenght;

        }

        private void CalculatWeigthForEachRow(List<NewOrderVM> data)
        {
           
            foreach (var row in data)
            {
                row.Weight = ((Math.Pow((row.Diameter / 1000), 2) * 1000 * Math.PI * 1.96) * (row.TotalLength / 100) * row.Amount);
            
            }

            txtTotalWeight.Text = data.Select(x => x.Weight).Sum().ToString();
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
                                            sDrawX = currentX - 14;
                                            sDrawY = ((currentY + tempNextY) / 2) - 6;
                                        }
                                        else if (currentY == tempNextY)
                                        {
                                            sDrawX = ((currentX + tempNextX) / 2) - 6;
                                            sDrawY = currentY - 13;  
                                        }
                                        else
                                        {
                                            sDrawX = currentX + 2;
                                            sDrawY = currentY  - 6;

                                        }

                                        sLenght = line.Diminution;// Math.Abs((tempNextX - currentX) + (tempNextY - currentY));

                                        e.Graphics.DrawString(sLenght.ToString() , new Font(FontFamily.GenericSansSerif, 7), Brushes.BlueViolet, sDrawX, sDrawY, StringFormat.GenericDefault);


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

        private void dataGridNewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var data = (NewOrderVM)dataGridNewOrders.Rows[e.RowIndex].DataBoundItem;

                var frm = new FormEditDimunsion();
                frm.ordrVM = data;
                DialogResult res = frm.ShowDialog();

                if (res == DialogResult.Yes)
                {
                    GenerateData();
                
                }
                //if (dataChangedFromNewOrder)
                //{
                //    GenerateData();
                //}

            }
        }
    }
}
