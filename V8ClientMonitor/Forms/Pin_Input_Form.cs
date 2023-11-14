using System;
using System.Windows.Forms;

namespace V8ClientMonitor.Forms
{
    public partial class Pin_Input_Form : Form
    {
        InterceptMouse obj;
        public string pin;

        public Pin_Input_Form()
        {
            InitializeComponent();
        }

        #region Num Buttens Click

        private void NumBT1_Click(object sender, EventArgs e)
        {
            if (PinET.Text.Length < 4)
            {
                pin = pin + 1;
                PinET.Text = PinET.Text + "*";
                if (PinET.Text.Length == 4)
                {
                    NextBT.Visible = true;
                }
            };
        }

        private void NumBT2_Click(object sender, EventArgs e)
        {
            if (PinET.Text.Length < 4)
            {
                pin = pin + 2;
                PinET.Text = PinET.Text + "*";
                if (PinET.Text.Length == 4)
                {
                    NextBT.Visible = true;
                }
            };

        }

        private void NumBT3_Click(object sender, EventArgs e)
        {
            if (PinET.Text.Length < 4)
            {
                pin = pin + 3;
                PinET.Text = PinET.Text + "*";
                if (PinET.Text.Length == 4)
                {
                    NextBT.Visible = true;
                }
            };
        }

        private void NumBT4_Click(object sender, EventArgs e)
        {
            if (PinET.Text.Length < 4)
            {
                pin = pin + 4;
                PinET.Text = PinET.Text + "*";
                if (PinET.Text.Length == 4)
                {
                    NextBT.Visible = true;
                }
            };


        }

        private void NumBT5_Click(object sender, EventArgs e)
        {
            if (PinET.Text.Length < 4)
            {
                pin = pin + 5;
                PinET.Text = PinET.Text + "*";
                if (PinET.Text.Length == 4)
                {
                    NextBT.Visible = true;
                }
            };
        }

        private void NumBT6_Click(object sender, EventArgs e)
        {
            if (PinET.Text.Length < 4)
            {
                pin = pin + 6;
                PinET.Text = PinET.Text + "*";
                if (PinET.Text.Length == 4)
                {
                    NextBT.Visible = true;
                }
            };
        }

        private void NumBT7_Click(object sender, EventArgs e)
        {
            if (PinET.Text.Length < 4)
            {
                pin = pin + 7;
                PinET.Text = PinET.Text + "*";
                if (PinET.Text.Length == 4)
                {
                    NextBT.Visible = true;
                }
            };
        }

        private void NumBT8_Click(object sender, EventArgs e)
        {
            if (PinET.Text.Length < 4)
            {
                pin = pin + 8;
                PinET.Text = PinET.Text + "*";
                if (PinET.Text.Length == 4)
                {
                    NextBT.Visible = true;
                }
            };
        }

        private void NumBT9_Click(object sender, EventArgs e)
        {
            if (PinET.Text.Length < 4)
            {
                pin = pin + 9;
                PinET.Text = PinET.Text + "*";
                if (PinET.Text.Length == 4)
                {
                    NextBT.Visible = true;
                }
            };
        }

        private void NumBT0_Click(object sender, EventArgs e)
        {
            if (PinET.Text.Length < 4)
            {
                pin = pin + 0;
                PinET.Text = PinET.Text + "*";
                if (PinET.Text.Length == 4)
                {
                    NextBT.Visible = true;
                }
            };
        }

        #endregion

        private void CleareBT_Click(object sender, EventArgs e)
        {
            if (pin.Length > 0)
            {
                NextBT.Visible = false;
                PinET.Text = ""; pin = "";
            }
        }


        private void CanselBT_Click(object sender, EventArgs e)
        {
            V8Data.AsyncEvent.ExternalEvent("компонент", "компонентСобытие", "-1");
            //obj.stop();
            //System.Windows.Forms.Cursor.Show();
            this.Close();
            this.Dispose();
        }

        private void NextBT_Click(object sender, EventArgs e)
        {

            V8Data.AsyncEvent.ExternalEvent("компонент", "компонентСобытие", pin);
        }

        private void Pin_Input_Form_Load(object sender, EventArgs e)
        {
            //obj = new InterceptMouse();
            //System.Windows.Forms.Cursor.Hide();
            //obj.start();
        }



    }
}
