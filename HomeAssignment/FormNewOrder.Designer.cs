
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
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.dtDateOfOrder = new System.Windows.Forms.DateTimePicker();
            this.dtEstDataOfSupply = new System.Windows.Forms.DateTimePicker();
            this.DropDownOrderStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOrderName = new System.Windows.Forms.TextBox();
            this.txtTotalWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNewOrders)).BeginInit();
            this.panelMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridNewOrders
            // 
            this.dataGridNewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNewOrders.Location = new System.Drawing.Point(0, 193);
            this.dataGridNewOrders.Name = "dataGridNewOrders";
            this.dataGridNewOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridNewOrders.RowTemplate.Height = 25;
            this.dataGridNewOrders.Size = new System.Drawing.Size(791, 265);
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
            this.btnUploadPDF.Location = new System.Drawing.Point(9, 9);
            this.btnUploadPDF.Name = "btnUploadPDF";
            this.btnUploadPDF.Size = new System.Drawing.Size(89, 23);
            this.btnUploadPDF.TabIndex = 4;
            this.btnUploadPDF.Text = "Upload PDF";
            this.btnUploadPDF.UseVisualStyleBackColor = true;
            this.btnUploadPDF.Click += new System.EventHandler(this.btnUploadPDF_Click);
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.Controls.Add(this.dtDateOfOrder);
            this.panelMainContainer.Controls.Add(this.dtEstDataOfSupply);
            this.panelMainContainer.Controls.Add(this.DropDownOrderStatus);
            this.panelMainContainer.Controls.Add(this.btnSave);
            this.panelMainContainer.Controls.Add(this.txtOrderName);
            this.panelMainContainer.Controls.Add(this.txtTotalWeight);
            this.panelMainContainer.Controls.Add(this.label7);
            this.panelMainContainer.Controls.Add(this.label4);
            this.panelMainContainer.Controls.Add(this.label5);
            this.panelMainContainer.Controls.Add(this.txtOrderId);
            this.panelMainContainer.Controls.Add(this.label3);
            this.panelMainContainer.Controls.Add(this.label2);
            this.panelMainContainer.Controls.Add(this.label1);
            this.panelMainContainer.Location = new System.Drawing.Point(0, 35);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(791, 162);
            this.panelMainContainer.TabIndex = 7;
            // 
            // dtDateOfOrder
            // 
            this.dtDateOfOrder.CustomFormat = "dd/MM/yyyy";
            this.dtDateOfOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateOfOrder.Location = new System.Drawing.Point(466, 86);
            this.dtDateOfOrder.Name = "dtDateOfOrder";
            this.dtDateOfOrder.RightToLeftLayout = true;
            this.dtDateOfOrder.Size = new System.Drawing.Size(227, 23);
            this.dtDateOfOrder.TabIndex = 12;
            // 
            // dtEstDataOfSupply
            // 
            this.dtEstDataOfSupply.CustomFormat = "dd/MM/yyyy";
            this.dtEstDataOfSupply.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEstDataOfSupply.Location = new System.Drawing.Point(12, 87);
            this.dtEstDataOfSupply.Name = "dtEstDataOfSupply";
            this.dtEstDataOfSupply.RightToLeftLayout = true;
            this.dtEstDataOfSupply.Size = new System.Drawing.Size(226, 23);
            this.dtEstDataOfSupply.TabIndex = 12;
            // 
            // DropDownOrderStatus
            // 
            this.DropDownOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownOrderStatus.FormattingEnabled = true;
            this.DropDownOrderStatus.Items.AddRange(new object[] {
            "Received by factory",
            "In progress",
            "Ready for delivery",
            "On the way",
            "Received to site"});
            this.DropDownOrderStatus.Location = new System.Drawing.Point(12, 17);
            this.DropDownOrderStatus.Name = "DropDownOrderStatus";
            this.DropDownOrderStatus.Size = new System.Drawing.Size(226, 23);
            this.DropDownOrderStatus.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(693, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOrderName
            // 
            this.txtOrderName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderName.Location = new System.Drawing.Point(466, 50);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrderName.Size = new System.Drawing.Size(227, 23);
            this.txtOrderName.TabIndex = 9;
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalWeight.Location = new System.Drawing.Point(12, 52);
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalWeight.Size = new System.Drawing.Size(226, 23);
            this.txtTotalWeight.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(242, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Est Date Of Supply";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(699, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Order Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(242, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Wight";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Enabled = false;
            this.txtOrderId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderId.Location = new System.Drawing.Point(466, 13);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrderId.Size = new System.Drawing.Size(227, 23);
            this.txtOrderId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(242, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Order Status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(698, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(701, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(301, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Order Status";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(41, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(256, 24);
            this.textBox2.TabIndex = 6;
            // 
            // FormNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 464);
            this.Controls.Add(this.panelMainContainer);
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
            this.Text = "Order";
            this.Load += new System.EventHandler(this.FormNewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNewOrders)).EndInit();
            this.panelMainContainer.ResumeLayout(false);
            this.panelMainContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridNewOrders;
        private System.Windows.Forms.Label lblPDFFileName;
        private System.Windows.Forms.Button btnUploadPDF;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOrderName;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox DropDownOrderStatus;
        private System.Windows.Forms.DateTimePicker dtEstDataOfSupply;
        private System.Windows.Forms.DateTimePicker dtDateOfOrder;
    }
}