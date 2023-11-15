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
    public partial class Smile_Form : Form
    {
        public Smile_Form()
        {
            InitializeComponent();
        }

        private void BadBT_Click(object sender, EventArgs e)
        {
            V8Data.AsyncEvent.ExternalEvent("компонент", "компонентСмайл", "1");
            this.Close(); 
            this.Dispose();

        }

        private void NormalBT_Click(object sender, EventArgs e)
        {
            V8Data.AsyncEvent.ExternalEvent("компонент", "компонентСмайл", "2");
            this.Close();
            this.Dispose();
        }

        private void GoodBT_Click(object sender, EventArgs e)
        {
            V8Data.AsyncEvent.ExternalEvent("компонент", "компонентСмайл", "3");
            this.Close();
            this.Dispose();
        }
    }
}
