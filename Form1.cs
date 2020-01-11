using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using UpdateDataBase.Forms;
namespace UpdateDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { List<string> DatabaseNames = new List<string>();


            SqlConnection sqlconnection = AD_Global.MakeConnectionString("BARG@logo", "sa", "192.168.1.78", "castlenoush_jadid");
            AD_Global.MakeCreateTableFile(sqlconnection, "BARG_Tablet_Group_Parameters");
            DataTable dt = AD_Global.LoadData("select * from BARG_Tablet_Group_Parameters", sqlconnection);
            //AD_Global.ExecQueryFromFile("C:\\Barg System", "BARG_Tablet_Group_Parameters", sqlconnection);
        }

        private void BtnDBSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDBSetting frmDBSetting = new frmDBSetting();
            frmDBSetting.Show();
        }
    }
}
