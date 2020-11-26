
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
            this.lblPDFFileName = new System.Windows.Forms.Label();
            this.btnUploadPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridNewOrders
            // 
            this.dataGridNewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNewOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridNewOrders.Location = new System.Drawing.Point(0, 38);
            this.dataGridNewOrders.Name = "dataGridNewOrders";
            this.dataGridNewOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridNewOrders.RowTemplate.Height = 25;
            this.dataGridNewOrders.Size = new System.Drawing.Size(791, 419);
            this.dataGridNewOrders.TabIndex = 0;
            this.dataGridNewOrders.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridNewOrders_CellPainting);
            // 
            // lblPDFFileName
            // 
            this.lblPDFFileName.Location = new System.Drawing.Point(110, 9);
            this.lblPDFFileName.Name = "lblPDFFileName";
            this.lblPDFFileName.Size = new System.Drawing.Size(681, 23);
            this.lblPDFFileName.TabIndex = 5;
            this.lblPDFFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUploadPDF
            // 
            this.btnUploadPDF.Location = new System.Drawing.Point(12, 9);
            this.btnUploadPDF.Name = "btnUploadPDF";
            this.btnUploadPDF.Size = new System.Drawing.Size(89, 23);
            this.btnUploadPDF.TabIndex = 4;
            this.btnUploadPDF.Text = "Upload PDF";
            this.btnUploadPDF.UseVisualStyleBackColor = true;
            this.btnUploadPDF.Click += new System.EventHandler(this.btnUploadPDF_Click);
            // 
            // FormNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 457);
            this.Controls.Add(this.lblPDFFileName);
            this.Controls.Add(this.btnUploadPDF);
            this.Controls.Add(this.dataGridNewOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Order";
            this.Load += new System.EventHandler(this.FormNewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNewOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridNewOrders;
        private System.Windows.Forms.Label lblPDFFileName;
        private System.Windows.Forms.Button btnUploadPDF;
    }
}