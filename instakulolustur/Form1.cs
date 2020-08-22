using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace instakulolustur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     #region  mouse click ayarları
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        public static void SolTik()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
        }
     #endregion
    
        private void Form1_Load(object sender, EventArgs e)
        {

            webBrowser1.Navigate("https://www.instagram.com/accounts/emailsignup/");
      
      //      webBrowser1.ScriptErrorsSuppressed = true;
            timer1.Start();
            timer1.Interval = 1000;
  
        }
 

        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           if (a == 5)
                webBrowser1.Document.GetElementById("emailOrPhone").InnerText = "spiderman.2002@outlook.com";
            //webbrows.daki sayfanın id si username olan textboxının textini orumcekadam yaptık
            else if (a == 6)
                webBrowser1.Document.GetElementById("fullName").InnerText = "sad1ky1ld1r1m";
            else if (a == 7)
                webBrowser1.Document.GetElementById("username").InnerText = "orumcexadam";
            else if (a == 8)
                webBrowser1.Document.GetElementById("password").InnerText = "sad1ky1ld1r1m";
            else if (a == 9)
            {
                //burda butonun id sini bilmedigimiz için tagı buton olan ların hepsini gezdık
                foreach (HtmlElement item in webBrowser1.Document.GetElementsByTagName("Button"))
                {// tagı button olan ve type ı submit olan elemana 
                    if (item.GetAttribute("type") == "submit")
                    {
                        item.InvokeMember("click");//tıkladık
                        break;
                    }
                }
            }
            //------------------------diğer sayfa---------------------------//
            else if (a == 11)
            {
                foreach (HtmlElement item in webBrowser1.Document.GetElementsByTagName("option"))
                {
                    //BURDA KALDIN HTML SELECT ETİKETİNDEN SECMEYİ BULAMADIN BULACAKSIN
                    if (item.GetAttribute("title") == "1995")
                    {
                        // string name = item.GetAttribute("title");
                        label1.Text = "1";
                        item.SetAttribute("selected", "selected");
                        Cursor.Position = webBrowser1.Parent.PointToScreen(new Point(390, 285));
                       // item.InvokeMember("onchange");
                       // item.InvokeMember("click");
                        SolTik();
                        SolTik();

                        Cursor.Position = webBrowser1.Parent.PointToScreen(new Point(390, 380));
                        SolTik();
                        break;
                    }
                }
            }
           //------------------------------onay sayfası------------------------------//
    else if(a==13)
            {
               foreach(HtmlElement item in webBrowser1.Document.GetElementsByTagName("input"))
                {//itemdeki oznitelikleri getir attribute oznitelik
                    if (item.GetAttribute("name") == "email_confirmation_code")
                    {

                        //buralara epostaya gelick olan kod geliyor.
                         item.InnerText = "123132";
                       item.SetAttribute("value", "123123");
                       // item.SetAttribute("data-focus-visible-added", "true");
                      webBrowser1.Document.GetElementsByTagName("button")[1].InvokeMember("click");  break;
                    }
                }

            }
           else if(a==15)
            {
                foreach(HtmlElement item in webBrowser1.Document.GetElementsByTagName("Button"))
                {
                    if(item.GetAttribute("type")=="submit")
                    {
                        item.InvokeMember("click");
                        break;
                            
                    }
                }
            }
            a++;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            var loc =webBrowser1.PointToClient(Cursor.Position);
            label2.Text = loc.X.ToString();
            label3.Text = loc.Y.ToString();
        }
    }
}
