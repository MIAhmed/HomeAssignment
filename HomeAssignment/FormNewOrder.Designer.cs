
namespace HomeAssignment
{
    partial class FormNewOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridNewOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridNewOrders
            // 
            this.dataGridNewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNewOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridNewOrders.Location = new System.Drawing.Point(0, 108);
            this.dataGridNewOrders.Name = "dataGridNewOrders";
            this.dataGridNewOrders.RowTemplate.Height = 25;
            this.dataGridNewOrders.Size = new System.Drawing.Size(909, 349);
            this.dataGridNewOrders.TabIndex = 0;
            this.dataGridNewOrders.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridNewOrders_CellPainting);
            // 
            // FormNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 457);
            this.Controls.Add(this.dataGridNewOrders);
            this.MaximizeBox = false;
            this.Name = "FormNewOrder";
            this.Text = "New Order";
            this.Load += new System.EventHandler(this.FormNewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNewOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridNewOrders;
    }
}