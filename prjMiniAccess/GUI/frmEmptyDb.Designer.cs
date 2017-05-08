namespace prjMiniAccess
{
    partial class frmEmptyDb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmptyDb));
            this.pctGeneralmage = new System.Windows.Forms.PictureBox();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.pctSaveDialog = new System.Windows.Forms.PictureBox();
            this.pctCreate = new System.Windows.Forms.PictureBox();
            this.lblPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctGeneralmage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSaveDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // pctGeneralmage
            // 
            this.pctGeneralmage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctGeneralmage.Image = ((System.Drawing.Image)(resources.GetObject("pctGeneralmage.Image")));
            this.pctGeneralmage.Location = new System.Drawing.Point(34, 34);
            this.pctGeneralmage.Name = "pctGeneralmage";
            this.pctGeneralmage.Size = new System.Drawing.Size(205, 206);
            this.pctGeneralmage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctGeneralmage.TabIndex = 0;
            this.pctGeneralmage.TabStop = false;
            // 
            // pctClose
            // 
            this.pctClose.Image = ((System.Drawing.Image)(resources.GetObject("pctClose.Image")));
            this.pctClose.Location = new System.Drawing.Point(589, -1);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(22, 24);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctClose.TabIndex = 1;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.pctClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F);
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(272, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Blank desktop database";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(273, 71);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(69, 19);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileName.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(277, 93);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(201, 25);
            this.txtFileName.TabIndex = 4;
            // 
            // pctSaveDialog
            // 
            this.pctSaveDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctSaveDialog.Image = ((System.Drawing.Image)(resources.GetObject("pctSaveDialog.Image")));
            this.pctSaveDialog.Location = new System.Drawing.Point(484, 93);
            this.pctSaveDialog.Name = "pctSaveDialog";
            this.pctSaveDialog.Size = new System.Drawing.Size(24, 24);
            this.pctSaveDialog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctSaveDialog.TabIndex = 5;
            this.pctSaveDialog.TabStop = false;
            this.pctSaveDialog.Click += new System.EventHandler(this.pctSaveDialog_Click);
            this.pctSaveDialog.MouseLeave += new System.EventHandler(this.pctSaveDialog_MouseLeave);
            this.pctSaveDialog.MouseHover += new System.EventHandler(this.pctSaveDialog_MouseHover);
            // 
            // pctCreate
            // 
            this.pctCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctCreate.Image = ((System.Drawing.Image)(resources.GetObject("pctCreate.Image")));
            this.pctCreate.Location = new System.Drawing.Point(277, 163);
            this.pctCreate.Name = "pctCreate";
            this.pctCreate.Size = new System.Drawing.Size(102, 100);
            this.pctCreate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctCreate.TabIndex = 7;
            this.pctCreate.TabStop = false;
            this.pctCreate.Click += new System.EventHandler(this.pctCreate_Click);
            this.pctCreate.MouseLeave += new System.EventHandler(this.pctCreate_MouseLeave);
            this.pctCreate.MouseHover += new System.EventHandler(this.pctCreate_MouseHover);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(277, 125);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(15, 13);
            this.lblPath.TabIndex = 8;
            this.lblPath.Text = "la";
            // 
            // frmEmptyDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(610, 289);
            this.ControlBox = false;
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.pctCreate);
            this.Controls.Add(this.pctSaveDialog);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pctClose);
            this.Controls.Add(this.pctGeneralmage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEmptyDb";
            this.Load += new System.EventHandler(this.frmEmptyDb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctGeneralmage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSaveDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCreate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctGeneralmage;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.PictureBox pctSaveDialog;
        private System.Windows.Forms.PictureBox pctCreate;
        private System.Windows.Forms.Label lblPath;
    }
}