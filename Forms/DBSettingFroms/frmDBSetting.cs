﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpdateDataBase.Forms.DBSettingFroms;
namespace UpdateDataBase.Forms
{
    public partial class frmDBSetting : Form
    {
        public frmDBSetting()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
           // sqlDataSource1.Fill();
        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddOrEditDataBaseConnection frmAddOrEditDataBaseConnection = new frmAddOrEditDataBaseConnection();
            frmAddOrEditDataBaseConnection.Show();
        }
    }
}
