using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V8ClientMonitor;

namespace TestMonitor
{
    public partial class Form1 : Form
    {
        MonitorComponent myMon;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myMon = new MonitorComponent();
            myMon.Init(null);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myMon.ИмяКарта = "Garik Asriyan";
            myMon.Баланс = "569";
            myMon.Бонус = "11,5";
            myMon.Сумма = "1125";
            myMon.Продукт = "Բանան կգ";
            myMon.кол = "2.153 կգ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            myMon.пинтекст = "Մուտքագրեք PIN-կոդը`";
            myMon.пин1с = "-3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            myMon.пин1с = "11";

        }
    }
}
