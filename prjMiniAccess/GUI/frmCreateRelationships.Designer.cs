namespace prjMiniAccess.GUI
{
    partial class frmCreateRelationships
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
            this.lblLeftTable = new System.Windows.Forms.Label();
            this.lblRightTable = new System.Windows.Forms.Label();
            this.cmbLeftTable = new System.Windows.Forms.ComboBox();
            this.cmbRightTable = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbRightColumn = new System.Windows.Forms.ComboBox();
            this.cmbLeftColumn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLeftColumn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLeftTable
            // 
            this.lblLeftTable.AutoSize = true;
            this.lblLeftTable.Location = new System.Drawing.Point(12, 14);
            this.lblLeftTable.Name = "lblLeftTable";
            this.lblLeftTable.Size = new System.Drawing.Size(86, 13);
            this.lblLeftTable.TabIndex = 0;
            this.lblLeftTable.Text = "Left Table Name";
            // 
            // lblRightTable
            // 
            this.lblRightTable.AutoSize = true;
            this.lblRightTable.Location = new System.Drawing.Point(220, 14);
            this.lblRightTable.Name = "lblRightTable";
            this.lblRightTable.Size = new System.Drawing.Size(93, 13);
            this.lblRightTable.TabIndex = 1;
            this.lblRightTable.Text = "Right Table Name";
            // 
            // cmbLeftTable
            // 
            this.cmbLeftTable.FormattingEnabled = true;
            this.cmbLeftTable.Location = new System.Drawing.Point(13, 30);
            this.cmbLeftTable.Name = "cmbLeftTable";
            this.cmbLeftTable.Size = new System.Drawing.Size(200, 21);
            this.cmbLeftTable.TabIndex = 2;
            this.cmbLeftTable.SelectedIndexChanged += new System.EventHandler(this.cmbLeftTable_SelectedIndexChanged);
            // 
            // cmbRightTable
            // 
            this.cmbRightTable.FormattingEnabled = true;
            this.cmbRightTable.Location = new System.Drawing.Point(220, 30);
            this.cmbRightTable.Name = "cmbRightTable";
            this.cmbRightTable.Size = new System.Drawing.Size(200, 21);
            this.cmbRightTable.TabIndex = 3;
            this.cmbRightTable.SelectedIndexChanged += new System.EventHandler(this.cmbRightTable_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(264, 118);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(345, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbRightColumn
            // 
            this.cmbRightColumn.FormattingEnabled = true;
            this.cmbRightColumn.Location = new System.Drawing.Point(222, 74);
            this.cmbRightColumn.Name = "cmbRightColumn";
            this.cmbRightColumn.Size = new System.Drawing.Size(200, 21);
            this.cmbRightColumn.TabIndex = 10;
            // 
            // cmbLeftColumn
            // 
            this.cmbLeftColumn.FormattingEnabled = true;
            this.cmbLeftColumn.Location = new System.Drawing.Point(15, 74);
            this.cmbLeftColumn.Name = "cmbLeftColumn";
            this.cmbLeftColumn.Size = new System.Drawing.Size(200, 21);
            this.cmbLeftColumn.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Right Column Name";
            // 
            // lblLeftColumn
            // 
            this.lblLeftColumn.AutoSize = true;
            this.lblLeftColumn.Location = new System.Drawing.Point(14, 58);
            this.lblLeftColumn.Name = "lblLeftColumn";
            this.lblLeftColumn.Size = new System.Drawing.Size(94, 13);
            this.lblLeftColumn.TabIndex = 7;
            this.lblLeftColumn.Text = "Left Column Name";
            // 
            // frmCreateRelationships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 153);
            this.Controls.Add(this.cmbRightColumn);
            this.Controls.Add(this.cmbLeftColumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLeftColumn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbRightTable);
            this.Controls.Add(this.cmbLeftTable);
            this.Controls.Add(this.lblRightTable);
            this.Controls.Add(this.lblLeftTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCreateRelationships";
            this.Text = "Create New";
            this.Load += new System.EventHandler(this.frmEditRelationships_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeftTable;
        private System.Windows.Forms.Label lblRightTable;
        private System.Windows.Forms.ComboBox cmbLeftTable;
        private System.Windows.Forms.ComboBox cmbRightTable;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbRightColumn;
        private System.Windows.Forms.ComboBox cmbLeftColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLeftColumn;
    }
}