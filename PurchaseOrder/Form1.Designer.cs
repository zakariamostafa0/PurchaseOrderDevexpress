namespace PurchaseOrder
{
    partial class Form1
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
            this.txtfilePath = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowData = new DevExpress.XtraEditors.SimpleButton();
            this.txtYear = new DevExpress.XtraEditors.TextEdit();
            this.txtMonth = new DevExpress.XtraEditors.TextEdit();
            this.txtPOType = new DevExpress.XtraEditors.TextEdit();
            this.Year = new DevExpress.XtraEditors.LabelControl();
            this.Month = new DevExpress.XtraEditors.LabelControl();
            this.POType = new DevExpress.XtraEditors.LabelControl();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSaveData = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPOType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfilePath
            // 
            this.txtfilePath.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtfilePath.Appearance.Font = new System.Drawing.Font("Arial", 11F);
            this.txtfilePath.Appearance.Options.UseBackColor = true;
            this.txtfilePath.Appearance.Options.UseFont = true;
            this.txtfilePath.ImageOptions.SvgImage = global::PurchaseOrder.Properties.Resources.exporttoxls;
            this.txtfilePath.Location = new System.Drawing.Point(12, 16);
            this.txtfilePath.LookAndFeel.SkinName = "McSkin";
            this.txtfilePath.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtfilePath.Name = "txtfilePath";
            this.txtfilePath.Size = new System.Drawing.Size(97, 34);
            this.txtfilePath.TabIndex = 0;
            this.txtfilePath.Text = "Exel file";
            this.txtfilePath.Click += new System.EventHandler(this.btnLoadExelFile_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Appearance.Font = new System.Drawing.Font("Arial", 11F);
            this.btnShowData.Appearance.Options.UseFont = true;
            this.btnShowData.Location = new System.Drawing.Point(400, 15);
            this.btnShowData.LookAndFeel.SkinName = "McSkin";
            this.btnShowData.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(95, 34);
            this.btnShowData.TabIndex = 1;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(240, 5);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(40, 20);
            this.txtYear.TabIndex = 2;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(240, 32);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(40, 20);
            this.txtMonth.TabIndex = 3;
            // 
            // txtPOType
            // 
            this.txtPOType.Location = new System.Drawing.Point(240, 58);
            this.txtPOType.Name = "txtPOType";
            this.txtPOType.Size = new System.Drawing.Size(40, 20);
            this.txtPOType.TabIndex = 4;
            // 
            // Year
            // 
            this.Year.Appearance.Font = new System.Drawing.Font("Arial", 11F);
            this.Year.Appearance.Options.UseFont = true;
            this.Year.Location = new System.Drawing.Point(171, 5);
            this.Year.LookAndFeel.SkinName = "McSkin";
            this.Year.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(31, 17);
            this.Year.TabIndex = 5;
            this.Year.Text = "Year";
            // 
            // Month
            // 
            this.Month.Appearance.Font = new System.Drawing.Font("Arial", 11F);
            this.Month.Appearance.Options.UseFont = true;
            this.Month.Location = new System.Drawing.Point(171, 32);
            this.Month.LookAndFeel.SkinName = "McSkin";
            this.Month.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(39, 17);
            this.Month.TabIndex = 5;
            this.Month.Text = "Month";
            // 
            // POType
            // 
            this.POType.Appearance.Font = new System.Drawing.Font("Arial", 11F);
            this.POType.Appearance.Options.UseFont = true;
            this.POType.Location = new System.Drawing.Point(171, 58);
            this.POType.LookAndFeel.SkinName = "McSkin";
            this.POType.LookAndFeel.UseDefaultLookAndFeel = false;
            this.POType.Name = "POType";
            this.POType.Size = new System.Drawing.Size(54, 17);
            this.POType.TabIndex = 5;
            this.POType.Text = "POType";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 99);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(831, 379);
            this.gridControl.TabIndex = 6;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Appearance.Font = new System.Drawing.Font("Arial", 11F);
            this.btnSaveData.Appearance.Options.UseFont = true;
            this.btnSaveData.Location = new System.Drawing.Point(601, 15);
            this.btnSaveData.LookAndFeel.SkinName = "McSkin";
            this.btnSaveData.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(95, 34);
            this.btnSaveData.TabIndex = 7;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 490);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.POType);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.txtPOType);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.txtfilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPOType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton txtfilePath;
        private DevExpress.XtraEditors.SimpleButton btnShowData;
        private DevExpress.XtraEditors.TextEdit txtYear;
        private DevExpress.XtraEditors.TextEdit txtMonth;
        private DevExpress.XtraEditors.TextEdit txtPOType;
        private DevExpress.XtraEditors.LabelControl Year;
        private DevExpress.XtraEditors.LabelControl Month;
        private DevExpress.XtraEditors.LabelControl POType;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnSaveData;
    }
}

