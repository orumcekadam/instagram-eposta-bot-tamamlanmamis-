using System;
using System.Windows.Forms;

namespace instakulolustur
{
    public partial class epostagiris : Form
    {
        public epostagiris()
        {
            InitializeComponent();
        }

        private void epostagiris_Load(object sender, EventArgs e)
        {
            webBrowser2.Navigate("https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1597692809&rver=7.0.6737.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fnlp%3d1%26RpsCsrfState%3d72a602d8-6864-4769-5f02-92e8b4f9820c&id=292841&aadredir=1&whr=hotmail.com&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=90015");
            timer1.Interval = 1000;
            timer1.Start();
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 4)
                webBrowser2.Document.GetElementById("i0116").InnerText = "onaylandiniz@hotmail.com";
            else if (a == 5) 
                webBrowser2.Document.GetElementById("idSIButton9").InvokeMember("click");
            else if (a == 7)
                webBrowser2.Document.GetElementById("i0118").InnerText = "onaylandi123";
            else if (a == 8) 
                webBrowser2.Document.GetElementById("idSIButton9").InvokeMember("click");
            a++;
        }

       
    }
}

