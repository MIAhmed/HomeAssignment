﻿
namespace HomeAssignment
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.pictureLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridOrders.Location = new System.Drawing.Point(0, 31);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridOrders.RowTemplate.Height = 25;
            this.dataGridOrders.Size = new System.Drawing.Size(800, 419);
            this.dataGridOrders.TabIndex = 1;
            this.dataGridOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrders_CellClick);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(11, 4);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(89, 22);
            this.btnNewOrder.TabIndex = 5;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // pictureLoading
            // 
            this.pictureLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureLoading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureLoading.Image")));
            this.pictureLoading.Location = new System.Drawing.Point(261, 154);
            this.pictureLoading.Name = "pictureLoading";
            this.pictureLoading.Size = new System.Drawing.Size(301, 140);
            this.pictureLoading.TabIndex = 6;
            this.pictureLoading.TabStop = false;
            this.pictureLoading.Visible = false;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureLoading);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.dataGridOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOrders";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.PictureBox pictureLoading;
    }
}