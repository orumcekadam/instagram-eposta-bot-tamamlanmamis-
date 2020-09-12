using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace instakulolustur
{
    public partial class email_acıcı : Form
    {
	
		public email_acıcı()
        {
            InitializeComponent();
        }

        private void email_acıcı_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://accounts.google.com/signup/v2/webcreateaccount?continue=https%3A%2F%2Fwww.google.com%2Fwebhp%3Fauthuser%3D0&hl=tr&dsh=S1258631056%3A1599921527311374&gmb=exp&biz=false&flowName=GlifWebSignIn&flowEntry=SignUp");
        }

       
    }
}
