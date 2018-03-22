using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TuneStore_8_feb_2018 {
    /// <summary>
    /// Found online at https://stackoverflow.com/a/14295249
    /// </summary>
    public static class NotepadHelperDSte {
        #region DLL imports
        [DllImport("user32.dll", EntryPoint = "SetWindowText")]
        private static extern int SetWindowText(IntPtr hWnd, string text);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
        #endregion

        /// <summary>
        /// Opens a notepad window with a specified title and text
        /// </summary>
        /// <param name="message">The text that is in the notepad window</param>
        /// <param name="title">The title that the window has</param>
        public static void ShowMessage(string message = null, string title = null) {
            //Start a new proccess
            Process notepad = Process.Start(new ProcessStartInfo("notepad.exe"));
            if (notepad != null) {
                notepad.WaitForInputIdle();
                //If the title is not null or empty set it as the title
                if (!string.IsNullOrEmpty(title))
                    SetWindowText(notepad.MainWindowHandle, title);

                //If the message is not null or empty set it as the text in the notepad window
                if (!string.IsNullOrEmpty(message)) {
                    IntPtr child = FindWindowEx(notepad.MainWindowHandle, new IntPtr(0), "Edit", null);
                    SendMessage(child, 0x000C, 0, message);
                }
            }
        }
    }
}
