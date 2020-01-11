namespace UpdateDataBase.Forms.DBSettingFroms
{
    partial class frmAddOrEditDataBaseConnection
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip9 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem9 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrEditDataBaseConnection));
            DevExpress.Utils.SuperToolTip superToolTip10 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem10 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip11 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem11 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip12 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem12 = new DevExpress.Utils.ToolTipTitleItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtIPAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassWord = new DevExpress.XtraEditors.TextEdit();
            this.lblCheckOk = new DevExpress.XtraEditors.LabelControl();
            this.lblCheckFalse = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbDBName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataBaseConnectionStringBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingDBDataSet = new UpdateDataBase.settingDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.txtIPAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDBName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseConnectionStringBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.labelControl1.Location = new System.Drawing.Point(47, 70);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Server IP:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 163);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            toolTipTitleItem9.Text = "password\r\n";
            superToolTip9.Items.Add(toolTipTitleItem9);
            this.labelControl2.SuperTip = superToolTip9;
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(40, 118);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "User Name:";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(115, 67);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(140, 20);
            this.txtIPAddress.TabIndex = 3;
            this.txtIPAddress.TextChanged += new System.EventHandler(this.TxtIPAddress_TextChanged);
            this.txtIPAddress.Leave += new System.EventHandler(this.TxtIPAddress_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(115, 115);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 20);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Leave += new System.EventHandler(this.TxtUserName_Leave);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(115, 160);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Properties.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(140, 20);
            this.txtPassWord.TabIndex = 5;
            this.txtPassWord.Leave += new System.EventHandler(this.TxtPassWord_Leave);
            // 
            // lblCheckOk
            // 
            this.lblCheckOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblCheckOk.ImageOptions.Image")));
            this.lblCheckOk.Location = new System.Drawing.Point(263, 68);
            this.lblCheckOk.Name = "lblCheckOk";
            this.lblCheckOk.Size = new System.Drawing.Size(16, 16);
            toolTipTitleItem10.Text = "This Address is Valid!";
            superToolTip10.Items.Add(toolTipTitleItem10);
            this.lblCheckOk.SuperTip = superToolTip10;
            this.lblCheckOk.TabIndex = 6;
            this.lblCheckOk.Visible = false;
            // 
            // lblCheckFalse
            // 
            this.lblCheckFalse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblCheckFalse.ImageOptions.Image")));
            this.lblCheckFalse.Location = new System.Drawing.Point(263, 68);
            this.lblCheckFalse.Name = "lblCheckFalse";
            this.lblCheckFalse.Size = new System.Drawing.Size(16, 16);
            toolTipTitleItem11.Text = "This Address is Not Valid!";
            superToolTip11.Items.Add(toolTipTitleItem11);
            this.lblCheckFalse.SuperTip = superToolTip11;
            this.lblCheckFalse.TabIndex = 7;
            this.lblCheckFalse.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(49, 205);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            toolTipTitleItem12.Text = "password\r\n";
            superToolTip12.Items.Add(toolTipTitleItem12);
            this.labelControl4.SuperTip = superToolTip12;
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "DB Name:";
            // 
            // cbDBName
            // 
            this.cbDBName.Location = new System.Drawing.Point(115, 202);
            this.cbDBName.Name = "cbDBName";
            this.cbDBName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDBName.Properties.Sorted = true;
            this.cbDBName.Size = new System.Drawing.Size(140, 20);
            this.cbDBName.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnSubmit.Location = new System.Drawing.Point(178, 270);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 30);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.simpleButton1.Location = new System.Drawing.Point(49, 270);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(89, 30);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Cancel";
            // 
            // dataBaseConnectionStringBindingSource
            // 
            this.dataBaseConnectionStringBindingSource.DataSource = this.settingDBDataSet;
            this.dataBaseConnectionStringBindingSource.Position = 0;
            // 
            // settingDBDataSet
            // 
            this.settingDBDataSet.DataSetName = "settingDBDataSet";
            this.settingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmAddOrEditDataBaseConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 331);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbDBName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblCheckFalse);
            this.Controls.Add(this.lblCheckOk);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddOrEditDataBaseConnection";
            this.Text = "frmAddOrEditDataBaseConnection";
            this.Load += new System.EventHandler(this.FrmAddOrEditDataBaseConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIPAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDBName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseConnectionStringBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtIPAddress;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassWord;
        private DevExpress.XtraEditors.LabelControl lblCheckOk;
        private DevExpress.XtraEditors.LabelControl lblCheckFalse;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbDBName;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource dataBaseConnectionStringBindingSource;
        private settingDBDataSet settingDBDataSet;
    }
}