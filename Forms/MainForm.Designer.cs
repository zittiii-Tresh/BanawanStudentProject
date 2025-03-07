namespace BanawanStudentProject
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.idLC = new DevExpress.XtraEditors.LabelControl();
            this.nameLC = new DevExpress.XtraEditors.LabelControl();
            this.ageLC = new DevExpress.XtraEditors.LabelControl();
            this.bdayLC = new DevExpress.XtraEditors.LabelControl();
            this.yearsectionLC = new DevExpress.XtraEditors.LabelControl();
            this.idTE = new DevExpress.XtraEditors.TextEdit();
            this.nameTE = new DevExpress.XtraEditors.TextEdit();
            this.ageTE = new DevExpress.XtraEditors.TextEdit();
            this.bdayDE = new DevExpress.XtraEditors.DateEdit();
            this.yearsectionTE = new DevExpress.XtraEditors.TextEdit();
            this.gcStudent = new DevExpress.XtraGrid.GridControl();
            this.gvStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StudentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StudentAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StudentBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YearSection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.createBTN = new DevExpress.XtraEditors.SimpleButton();
            this.updateBTN = new DevExpress.XtraEditors.SimpleButton();
            this.deleteBTN = new DevExpress.XtraEditors.SimpleButton();
            this.clearBTN = new DevExpress.XtraEditors.SimpleButton();
            this.loadBTN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.idTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdayDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdayDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsectionTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // idLC
            // 
            this.idLC.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLC.Appearance.Options.UseFont = true;
            this.idLC.Location = new System.Drawing.Point(17, 65);
            this.idLC.Name = "idLC";
            this.idLC.Size = new System.Drawing.Size(63, 17);
            this.idLC.TabIndex = 0;
            this.idLC.Text = "Student ID:";
            // 
            // nameLC
            // 
            this.nameLC.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLC.Appearance.Options.UseFont = true;
            this.nameLC.Location = new System.Drawing.Point(208, 65);
            this.nameLC.Name = "nameLC";
            this.nameLC.Size = new System.Drawing.Size(86, 17);
            this.nameLC.TabIndex = 1;
            this.nameLC.Text = "Student Name:";
            // 
            // ageLC
            // 
            this.ageLC.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLC.Appearance.Options.UseFont = true;
            this.ageLC.Location = new System.Drawing.Point(400, 65);
            this.ageLC.Name = "ageLC";
            this.ageLC.Size = new System.Drawing.Size(74, 17);
            this.ageLC.TabIndex = 2;
            this.ageLC.Text = "Student Age:";
            // 
            // bdayLC
            // 
            this.bdayLC.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdayLC.Appearance.Options.UseFont = true;
            this.bdayLC.Location = new System.Drawing.Point(593, 65);
            this.bdayLC.Name = "bdayLC";
            this.bdayLC.Size = new System.Drawing.Size(55, 17);
            this.bdayLC.TabIndex = 3;
            this.bdayLC.Text = "Birthdate:";
            // 
            // yearsectionLC
            // 
            this.yearsectionLC.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsectionLC.Appearance.Options.UseFont = true;
            this.yearsectionLC.Location = new System.Drawing.Point(781, 65);
            this.yearsectionLC.Name = "yearsectionLC";
            this.yearsectionLC.Size = new System.Drawing.Size(101, 17);
            this.yearsectionLC.TabIndex = 4;
            this.yearsectionLC.Text = "Year and Section:";
            // 
            // idTE
            // 
            this.idTE.Location = new System.Drawing.Point(17, 25);
            this.idTE.Name = "idTE";
            this.idTE.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.idTE.Properties.MaskSettings.Set("mask", "d");
            this.idTE.Size = new System.Drawing.Size(165, 34);
            this.idTE.TabIndex = 5;
            // 
            // nameTE
            // 
            this.nameTE.Location = new System.Drawing.Point(208, 25);
            this.nameTE.Name = "nameTE";
            this.nameTE.Size = new System.Drawing.Size(165, 34);
            this.nameTE.TabIndex = 6;
            // 
            // ageTE
            // 
            this.ageTE.Location = new System.Drawing.Point(400, 25);
            this.ageTE.Name = "ageTE";
            this.ageTE.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.ageTE.Properties.MaskSettings.Set("mask", "d");
            this.ageTE.Size = new System.Drawing.Size(165, 34);
            this.ageTE.TabIndex = 7;
            // 
            // bdayDE
            // 
            this.bdayDE.EditValue = null;
            this.bdayDE.Location = new System.Drawing.Point(590, 25);
            this.bdayDE.Name = "bdayDE";
            this.bdayDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bdayDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bdayDE.Properties.MaskSettings.Set("mask", "d");
            this.bdayDE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.bdayDE.Size = new System.Drawing.Size(165, 34);
            this.bdayDE.TabIndex = 8;
            // 
            // yearsectionTE
            // 
            this.yearsectionTE.Location = new System.Drawing.Point(781, 25);
            this.yearsectionTE.Name = "yearsectionTE";
            this.yearsectionTE.Size = new System.Drawing.Size(165, 34);
            this.yearsectionTE.TabIndex = 9;
            // 
            // gcStudent
            // 
            this.gcStudent.Location = new System.Drawing.Point(17, 134);
            this.gcStudent.MainView = this.gvStudent;
            this.gcStudent.Name = "gcStudent";
            this.gcStudent.Size = new System.Drawing.Size(929, 371);
            this.gcStudent.TabIndex = 10;
            this.gcStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudent});
            // 
            // gvStudent
            // 
            this.gvStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StudentID,
            this.StudentName,
            this.StudentAge,
            this.StudentBirthday,
            this.YearSection});
            this.gvStudent.GridControl = this.gcStudent;
            this.gvStudent.Name = "gvStudent";
            this.gvStudent.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvStudent_RowClick);
            // 
            // StudentID
            // 
            this.StudentID.AppearanceCell.Options.UseTextOptions = true;
            this.StudentID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.StudentID.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.AppearanceHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.StudentID.AppearanceHeader.Options.UseFont = true;
            this.StudentID.AppearanceHeader.Options.UseForeColor = true;
            this.StudentID.Caption = "Student ID";
            this.StudentID.FieldName = "StudentID";
            this.StudentID.MinWidth = 25;
            this.StudentID.Name = "StudentID";
            this.StudentID.OptionsColumn.AllowEdit = false;
            this.StudentID.OptionsColumn.AllowFocus = false;
            this.StudentID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.StudentID.Visible = true;
            this.StudentID.VisibleIndex = 0;
            this.StudentID.Width = 94;
            // 
            // StudentName
            // 
            this.StudentName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName.AppearanceHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.StudentName.AppearanceHeader.Options.UseFont = true;
            this.StudentName.AppearanceHeader.Options.UseForeColor = true;
            this.StudentName.Caption = "Student Name";
            this.StudentName.FieldName = "StudentName";
            this.StudentName.MinWidth = 25;
            this.StudentName.Name = "StudentName";
            this.StudentName.OptionsColumn.AllowEdit = false;
            this.StudentName.OptionsColumn.AllowFocus = false;
            this.StudentName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.StudentName.Visible = true;
            this.StudentName.VisibleIndex = 1;
            this.StudentName.Width = 94;
            // 
            // StudentAge
            // 
            this.StudentAge.AppearanceCell.Options.UseTextOptions = true;
            this.StudentAge.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.StudentAge.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.StudentAge.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentAge.AppearanceHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.StudentAge.AppearanceHeader.Options.UseFont = true;
            this.StudentAge.AppearanceHeader.Options.UseForeColor = true;
            this.StudentAge.Caption = "Age";
            this.StudentAge.FieldName = "StudentAge";
            this.StudentAge.MinWidth = 25;
            this.StudentAge.Name = "StudentAge";
            this.StudentAge.OptionsColumn.AllowEdit = false;
            this.StudentAge.OptionsColumn.AllowFocus = false;
            this.StudentAge.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.StudentAge.Visible = true;
            this.StudentAge.VisibleIndex = 2;
            this.StudentAge.Width = 94;
            // 
            // StudentBirthday
            // 
            this.StudentBirthday.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentBirthday.AppearanceHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.StudentBirthday.AppearanceHeader.Options.UseFont = true;
            this.StudentBirthday.AppearanceHeader.Options.UseForeColor = true;
            this.StudentBirthday.Caption = "Birthdate";
            this.StudentBirthday.FieldName = "StudentBirthday";
            this.StudentBirthday.MinWidth = 25;
            this.StudentBirthday.Name = "StudentBirthday";
            this.StudentBirthday.OptionsColumn.AllowEdit = false;
            this.StudentBirthday.OptionsColumn.AllowFocus = false;
            this.StudentBirthday.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.StudentBirthday.Visible = true;
            this.StudentBirthday.VisibleIndex = 3;
            this.StudentBirthday.Width = 94;
            // 
            // YearSection
            // 
            this.YearSection.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearSection.AppearanceHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.YearSection.AppearanceHeader.Options.UseFont = true;
            this.YearSection.AppearanceHeader.Options.UseForeColor = true;
            this.YearSection.Caption = "Year and Section";
            this.YearSection.FieldName = "StudentYearSection";
            this.YearSection.MinWidth = 25;
            this.YearSection.Name = "YearSection";
            this.YearSection.OptionsColumn.AllowEdit = false;
            this.YearSection.OptionsColumn.AllowFocus = false;
            this.YearSection.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.YearSection.Visible = true;
            this.YearSection.VisibleIndex = 4;
            this.YearSection.Width = 94;
            // 
            // createBTN
            // 
            this.createBTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("createBTN.ImageOptions.SvgImage")));
            this.createBTN.Location = new System.Drawing.Point(553, 88);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(94, 37);
            this.createBTN.TabIndex = 11;
            this.createBTN.Text = "Add";
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("updateBTN.ImageOptions.SvgImage")));
            this.updateBTN.Location = new System.Drawing.Point(653, 88);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(94, 37);
            this.updateBTN.TabIndex = 12;
            this.updateBTN.Text = "Update";
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("deleteBTN.ImageOptions.SvgImage")));
            this.deleteBTN.Location = new System.Drawing.Point(753, 88);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(94, 37);
            this.deleteBTN.TabIndex = 13;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clearBTN.ImageOptions.SvgImage")));
            this.clearBTN.Location = new System.Drawing.Point(453, 88);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(94, 37);
            this.clearBTN.TabIndex = 14;
            this.clearBTN.Text = "Clear";
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // loadBTN
            // 
            this.loadBTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("loadBTN.ImageOptions.SvgImage")));
            this.loadBTN.Location = new System.Drawing.Point(853, 88);
            this.loadBTN.Name = "loadBTN";
            this.loadBTN.Size = new System.Drawing.Size(94, 37);
            this.loadBTN.TabIndex = 15;
            this.loadBTN.Text = "Load";
            this.loadBTN.Click += new System.EventHandler(this.loadBTN_Click);
            // 
            // StudentForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 527);
            this.Controls.Add(this.loadBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.gcStudent);
            this.Controls.Add(this.yearsectionTE);
            this.Controls.Add(this.bdayDE);
            this.Controls.Add(this.ageTE);
            this.Controls.Add(this.nameTE);
            this.Controls.Add(this.idTE);
            this.Controls.Add(this.yearsectionLC);
            this.Controls.Add(this.bdayLC);
            this.Controls.Add(this.ageLC);
            this.Controls.Add(this.nameLC);
            this.Controls.Add(this.idLC);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentForm";
            this.Text = "Student Form";
            ((System.ComponentModel.ISupportInitialize)(this.idTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdayDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdayDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsectionTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl idLC;
        private DevExpress.XtraEditors.LabelControl nameLC;
        private DevExpress.XtraEditors.LabelControl ageLC;
        private DevExpress.XtraEditors.LabelControl bdayLC;
        private DevExpress.XtraEditors.LabelControl yearsectionLC;
        private DevExpress.XtraEditors.TextEdit idTE;
        private DevExpress.XtraEditors.TextEdit nameTE;
        private DevExpress.XtraEditors.TextEdit ageTE;
        private DevExpress.XtraEditors.DateEdit bdayDE;
        private DevExpress.XtraEditors.TextEdit yearsectionTE;
        private DevExpress.XtraGrid.GridControl gcStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudent;
        private DevExpress.XtraEditors.SimpleButton createBTN;
        private DevExpress.XtraEditors.SimpleButton updateBTN;
        private DevExpress.XtraEditors.SimpleButton deleteBTN;
        private DevExpress.XtraGrid.Columns.GridColumn StudentID;
        private DevExpress.XtraGrid.Columns.GridColumn StudentName;
        private DevExpress.XtraGrid.Columns.GridColumn StudentAge;
        private DevExpress.XtraGrid.Columns.GridColumn StudentBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn YearSection;
        private DevExpress.XtraEditors.SimpleButton clearBTN;
        private DevExpress.XtraEditors.SimpleButton loadBTN;
    }
}

