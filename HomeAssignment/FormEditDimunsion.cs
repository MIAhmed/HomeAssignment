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
    public partial class FormEditDimunsion : Form
    {
        public FormEditDimunsion()
        {
            InitializeComponent();
        }

        public NewOrderVM ordrVM = null;
        private void dataGridDimunsions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormEditDimunsion_Load(object sender, EventArgs e)
        {
            if (ordrVM != null && ordrVM.Sketch != null && ordrVM.Sketch.Lines != null && ordrVM.Sketch.Lines.Count > 0)
            {

                dataGridDimunsions.DataSource = ordrVM.Sketch.Lines;
                dataGridDimunsions.Columns[0].Visible = false;
                dataGridDimunsions.Columns[1].Visible = false;
                dataGridDimunsions.Rows[0].Visible = false;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataGridDimunsions.EndEdit();

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void dataGridDimunsions_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2) 
            {
                float retVal;

                if (!float.TryParse(Convert.ToString(e.FormattedValue), out retVal))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter numeric value");
                }
                else
                {
                    // the input is numeric 
                }
            }
        }
    }
}
