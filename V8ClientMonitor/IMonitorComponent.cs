using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using V8ClientMonitor.Forms;

namespace V8ClientMonitor
{
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMonitorComponent
    {
        string ИмяКарта
        {
            get;set;
        }
        string Баланс
        {
            get; set;
        }
        string Бонус
        {
            get; set;
        }
        string Сумма
        {
            get; set;
        }
        string Продукт
        {
            get; set;
        }
        string кол
        {
            get; set;
        }

        string пин1с
        {
            get; set;
        }
        string пинтекст
        {
            get; set;
        }

        [RussianName("МетодНаРусскомЯзыке")]
        int Procedure(int parameter);

        void Procedure1();

        string Procedure3();

    }
}
