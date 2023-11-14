﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class InterceptMouse
{
    private static LowLevelMouseProc _proc = HookCallback;
    private static IntPtr _hookID = IntPtr.Zero;

    public void start()
    { _hookID = SetHook(_proc); }
    public void stop()
    { //System.Windows.Forms.Cursor.Show(); 
        UnhookWindowsHookEx(_hookID); }

    private static IntPtr SetHook(LowLevelMouseProc proc)
    {
        using (Process curProcess = Process.GetCurrentProcess())
        using (ProcessModule curModule = curProcess.MainModule)
        {
            return SetWindowsHookEx(WH_MOUSE_LL, proc,
                GetModuleHandle(curModule.ModuleName), 0);
        }
    }

    private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

    private static IntPtr HookCallback(
        int nCode, IntPtr wParam, IntPtr lParam)
    {

        if (MouseMessages.WM_LBUTTONUP == (MouseMessages)wParam && System.Windows.Forms.Cursor.Position.X < Screen.PrimaryScreen.Bounds.Width)
        {
            pt1 = new Point(System.Windows.Forms.Cursor.Position.X + Screen.PrimaryScreen.Bounds.Width, System.Windows.Forms.Cursor.Position.Y); System.Windows.Forms.Cursor.Position = pt1; //System.Windows.Forms.Cursor.Hide(); //return (IntPtr)1;

        }

        if (MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam)
        {


            if (System.Windows.Forms.Cursor.Position.X < Screen.PrimaryScreen.Bounds.Width)
            {


                LeftClick(System.Windows.Forms.Cursor.Position.X + Screen.PrimaryScreen.Bounds.Width, System.Windows.Forms.Cursor.Position.Y); return (IntPtr)1;

            };

            MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
            Console.WriteLine(hookStruct.pt.x + ", " + hookStruct.pt.y);
        }
        return CallNextHookEx(_hookID, nCode, wParam, lParam);
    }

    private static void LeftClick()
    {
        throw new NotImplementedException();
    }

    private const int WH_MOUSE_LL = 14;

    private enum MouseMessages
    {
        WM_LBUTTONDOWN = 0x0201,
        WM_LBUTTONUP = 0x0202,
        WM_MOUSEMOVE = 0x0200,
        WM_MOUSEWHEEL = 0x020A,
        WM_RBUTTONDOWN = 0x0204,
        WM_RBUTTONUP = 0x0205
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct POINT
    {
        public int x;
        public int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct MSLLHOOKSTRUCT
    {
        public POINT pt;
        public uint mouseData;
        public uint flags;
        public uint time;
        public IntPtr dwExtraInfo;
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook,
        LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
        IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("user32.dll")]
    public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

    [Flags]
    public enum MouseEventFlags
    {
        LEFTDOWN = 0x00000002,
        LEFTUP = 0x00000004,
        MIDDLEDOWN = 0x00000020,
        MIDDLEUP = 0x00000040,
        MOVE = 0x00000001,
        ABSOLUTE = 0x00008000,
        RIGHTDOWN = 0x00000008,
        RIGHTUP = 0x00000010
    }

    public static void LeftClick(int x, int y)
    {
        Cursor.Position = new System.Drawing.Point(x, y);
        //mouse_event((int)(MouseEventFlags.MOVE), 0, 0, 0, 0);
        mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
        mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
    }







    public static Point pt1 { get; set; }
}