
namespace HomeAssignment
{
    partial class FormEditDimunsion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditDimunsion));
            this.dataGridDimunsions = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDimunsions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDimunsions
            // 
            this.dataGridDimunsions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDimunsions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDimunsions.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridDimunsions.Location = new System.Drawing.Point(0, 0);
            this.dataGridDimunsions.Name = "dataGridDimunsions";
            this.dataGridDimunsions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridDimunsions.RowTemplate.Height = 25;
            this.dataGridDimunsions.Size = new System.Drawing.Size(253, 196);
            this.dataGridDimunsions.TabIndex = 2;
            this.dataGridDimunsions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDimunsions_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(12, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormEditDimunsion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 230);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridDimunsions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditDimunsion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Dimunsions";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormEditDimunsion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDimunsions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDimunsions;
        private System.Windows.Forms.Button btnSave;
    }
}