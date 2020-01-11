using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateDataBase.Forms.DBSettingFroms
{
    public partial class frmAddOrEditDataBaseConnection : Form
    {
        public frmAddOrEditDataBaseConnection()
        {
            InitializeComponent();
        }

        private void FrmAddOrEditDataBaseConnection_Load(object sender, EventArgs e)
        {
           
        }
      
        private void TxtIPAddress_Leave(object sender, EventArgs e)
        {
            IPAddress ipAddress;
            if (IPAddress.TryParse(txtIPAddress.Text, out ipAddress))
            {
                lblCheckFalse.Visible = false;
                lblCheckOk.Visible = true;
                FillCbDBName();
            }
            else
            {
                lblCheckFalse.Visible = true;
                lblCheckOk.Visible = false;
            }
        }

        private void TxtIPAddress_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            FillCbDBName();
        }
        public void FillCbDBName()
        {
            List<string> DataBaseNames = new List<string>();
            DataBaseNames.AddRange(AD_Global.GetDatabaseList(txtIPAddress.Text, txtUserName.Text, txtPassWord.Text));
            cbDBName.Properties.Items.Clear();
            foreach (var item in DataBaseNames)
            {
                cbDBName.Properties.Items.Add(item);

            }
        }
        private void TxtPassWord_Leave(object sender, EventArgs e)
        {
            FillCbDBName();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
      
            using(settingDBEntities db =new settingDBEntities())
            {
                ConnectionStrings cs = new ConnectionStrings();
                List<ConnectionStrings> connectionStrings = db.ConnectionStrings.ToList();
                cs.ServerAddress = txtIPAddress.Text;
                cs.UserName = txtUserName.Text;
                cs.PassWord = txtPassWord.Text;
                cs.DBName = cbDBName.Text;
                cs.Id = 0;
               // db.Entry(cs).State = System.Data.Entity.EntityState.Added;
                db.ConnectionStrings.Add(cs);
                db.SaveChanges();
                
                
            }

        }
    }
}
