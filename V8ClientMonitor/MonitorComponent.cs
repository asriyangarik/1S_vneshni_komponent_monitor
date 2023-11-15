
using System.Runtime.InteropServices;
using System.Windows.Forms;
using V8ClientMonitor.Forms;

namespace V8ClientMonitor
{
    /// <summary>Класс, реализующий пользовательские методы компоненты</summary>
    [ProgId("AddIn.MonitorComponent")]
    [ClassInterface(ClassInterfaceType.None)]
    public class MonitorComponent : AddIn, IMonitorComponent
    {

        /// <summary>
        /// имя компоненты писать в AddinLib->Addin-> public const string AddInName = "MonitorComponent";
        /// не менять GUID - ы в папке AddinLib
        /// событие в 1с генерирует статические методы класса V8Data 
        /// методы и свойство 1С видет через интерфейс IMonitorComponent который реализован в MonitorComponent
        /// </summary>

        public Screen[] screens = Screen.AllScreens;
        public Main_Form _MainForm = new Main_Form();
        public Pin_Input_Form PinInputForm;
        public Smile_Form SmileForm;

        private string QartAnun;
        private string Balans;
        private string Bonus;
        private string Gumar;
        private string Apranq;
        private string Qanak;
        private string pin1c;
        private string pintext;



        public string ИмяКарта
        {
            get
            {
                return QartAnun;
            }
            set
            {
                QartAnun = value;
                _MainForm.CardNameTB.Text = value;
            }
        }
        public string Баланс
        {
            get
            {
                return Balans;
            }
            set
            {
                Balans = value;
                _MainForm.BalansTB.Text = value;
            }
        }
        public string Бонус
        {
            get
            {
                return Bonus;
            }
            set
            {
                Bonus = value;
                _MainForm.BonusTB.Text = value;
            }
        }
        public string Сумма
        {
            get
            {
                return Gumar;
            }
            set
            {
                Gumar = value;
                _MainForm.TotalTB.Text = value + " Դր.";
            }
        }
        public string Продукт
        {
            get
            {
                return Apranq;
            }
            set
            {
                Apranq = value;

                if (Apranq == "-1")
                {

                    _MainForm.ItemTB.ForeColor = System.Drawing.Color.Red;
                    _MainForm.ItemTB.Text = "               ԴՈՒՔ ԿՈՐՑՆՈՒՄ ԵՔ`";
                    _MainForm.item_countTB.ForeColor = System.Drawing.Color.Red;

                }
                else if (Apranq == "-2")
                {
                    _MainForm.ItemTB.ForeColor = System.Drawing.Color.Red;
                    _MainForm.item_countTB.ForeColor = System.Drawing.Color.Red;
                    _MainForm.ItemTB.Text = "              ԶԵՂՉԸ ԿԱԶՄԵԼ Է`";
                }
                else if (Apranq == "-3")
                {
                    _MainForm.ItemTB.ForeColor = System.Drawing.Color.Red;
                    _MainForm.item_countTB.ForeColor = System.Drawing.Color.Red;
                    _MainForm.ItemTB.Text = "              ԲՈՆՈՒՍԸ ԿԱԶՄԵԼ Է`";

                }
                else if (Apranq == "-4")
                {
                    _MainForm.ItemTB.ForeColor = System.Drawing.Color.Red;
                    _MainForm.item_countTB.ForeColor = System.Drawing.Color.Red;
                    _MainForm.ItemTB.Text = "              ՔԱՐՏԻՑ ՀԱՆՎԵԼ Է`";
                }
                else
                {

                    _MainForm.ItemTB.ForeColor = System.Drawing.Color.Blue;
                    _MainForm.ItemTB.Text = Apranq;
                    _MainForm.item_countTB.ForeColor = System.Drawing.Color.Blue;
                    //port1111.Write(Apranq);
                }
                // _MainForm.ItemTB.Text = value;
            }
        }
        public string кол
        {
            get
            {
                return Qanak;
            }
            set
            {
                Qanak = value;
                _MainForm.item_countTB.Text = value;
            }
        }
        public string пин1с
        {
            get
            {
                return pin1c;
            }
            set
            {
                pin1c = value;
                if (pin1c == "-3")
                {
                    PinInputForm = new Pin_Input_Form();
                    PinInputForm.ShowInTaskbar = false;

                    PinInputForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    PinInputForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                    if (screens.Length > 1)
                    {
                        PinInputForm.Location = screens[screens.Length - 1].WorkingArea.Location;
                    }
                    else
                    {
                        PinInputForm.Location = new System.Drawing.Point(1515, 15);
                    }

                    PinInputForm.label2.Text = пинтекст;
                    PinInputForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    PinInputForm.Show();
                    Cursor.Position = screens[screens.Length - 1].WorkingArea.Location;
                };
                if (pin1c == "-2")
                {
                    // PinInputForm.obj.stop(); 
                    // System.Windows.Forms.Cursor.Show();
                    PinInputForm.Close();
                    PinInputForm.Dispose();
                };

                if (pin1c == "-1")
                {

                    PinInputForm.label1.Text = "";
                    PinInputForm.pin = "";
                    PinInputForm.NextBT.Visible = false;
                    PinInputForm.PinET.Text = "";
                    PinInputForm.label2.Text = пинтекст;
                }
                if (pin1c == "11") 
                {
                    SmileForm = new Smile_Form();
                    SmileForm.ShowInTaskbar = false;
                    SmileForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    SmileForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                    if (screens.Length > 1)
                    {
                        SmileForm.Location = screens[screens.Length - 1].WorkingArea.Location;
                    }
                    else 
                    {
                        SmileForm.Location = new System.Drawing.Point(1515, 15);
                    }
                   
                    SmileForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    SmileForm.Show();
                };


            }
        }
        public string пинтекст
        {
            get
            {
                return pintext;
            }
            set
            {
                pintext = value;

            }
        }


        public MonitorComponent()
        {

            

        }

        public override void Init([MarshalAs(UnmanagedType.IDispatch)] object connection)
        {
            base.Init(connection);

            if (screens.Length >1)
            {
                _MainForm.ShowInTaskbar = false;

                _MainForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                _MainForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
               // _MainForm.Location = new System.Drawing.Point(1515, 15);
                _MainForm.Location = screens[screens.Length - 1].WorkingArea.Location;
                _MainForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                // kkkk.MouseMove += new System.Windows.Forms.MouseEventHandler();
                //  kkkk.label1.Location = new System.Drawing.Point(kkkk.Size.Width - 300, 600); 

                // kkkk.axWindowsMediaPlayer1.CanFocus = false;
                
                _MainForm.Show();

                // MessageBox.Show("Constructor OK");
            }
        }


        #region Test Metods

        public int Procedure(int parameter)
        {
            return 10;
        }

        public void Procedure1()
        {
            V8Data.AsyncEvent.ExternalEvent("bzbzbzbzzbzb", "Haykooo", "ԲռնիԴրան");
        }

        public string Procedure3()
        {
            return "OK";
        }

        #endregion
    }
}
