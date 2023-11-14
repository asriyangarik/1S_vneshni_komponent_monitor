using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V8ClientMonitor.Forms
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            MainFormPicureChange();
        }

        private async void MainFormPicureChange()
        {
            //try
            //{
            //    FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://192.168.0.229/Logo.jpg");
            //    request.Method = WebRequestMethods.Ftp.DownloadFile;
            //    request.Credentials = new NetworkCredential("Admin", "Mek1Erku2");

            //    FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            //    Stream responseStream = response.GetResponseStream();
            //    City_picture.Image = Image.FromStream(responseStream);
            //    City_picture.BackgroundImageLayout = ImageLayout.Zoom;
            //    response.Close();
            //}
            //catch (Exception)
            //{

            //}




        }
    }
}
