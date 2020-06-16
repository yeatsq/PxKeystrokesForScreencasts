using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PxKeystrokesUi
{
    class SpecialkeysParser
    {
        public static string ToString(Keys k)
        {
            switch(k){
                case Keys.Shift:
                case Keys.ShiftKey:
                case Keys.LShiftKey:
                case Keys.RShiftKey:
                    return "[Shift]";
                case Keys.Control:
                case Keys.ControlKey:
                case Keys.LControlKey:
                case Keys.RControlKey:
                    return "[Ctrl]";
                case Keys.LWin:
                case Keys.RWin:
                    return "[Win]";
                case Keys.Menu:
                case Keys.LMenu:
                case Keys.RMenu:
                    return "[Alt]";
                case Keys.CapsLock:
                    return "[CapsLock]";
                case Keys.LineFeed:
                case Keys.Return:
                    return "[Return]";
                case Keys.Back:
                    return "[Backspace]";
                case Keys.Left:
                    return " ← ";
                case Keys.Right:
                    return " → ";
                case Keys.Down:
                    return " ↓ ";
                case Keys.Up:
                    return " ↑ ";
                case Keys.Escape:
                    return " [Esc] ";
                case Keys.PrintScreen:
                    return " [Print] ";
                case Keys.Pause:
                    return " [Pause] ";
                case Keys.Insert:
                    return " [Insert] ";
                case Keys.Delete:
                    return " [Delete] ";


                case Keys.Tab:
                    return "[Tab]";
                case Keys.Space:
                    return "[Space]";
                case Keys.PageUp: 
                    return "[PgUp]";
                case Keys.PageDown:
                     return "[PgDn]";
                case Keys.End:
                    return "[End]";
                case Keys.Home:
                    return "[Home]";
                case Keys.Print:
                    return "[PrtSc]";

                case Keys.Clear:
                case Keys.ProcessKey:
                case Keys.Attn:
                case Keys.Crsel:
                case Keys.Exsel:
                case Keys.EraseEof:
                case Keys.Cancel:
                case Keys.Select:
                case Keys.Execute:
                case Keys.Help:
                case Keys.Apps:
                case Keys.Pa1:
                case Keys.Sleep:
                    return " [" + k.ToString() + "] ";

                case Keys.Multiply:
                    return "*";
                case Keys.Add:
                    return "+";
                case Keys.Separator:
                    return " [Seperator] ";
                case Keys.Subtract:
                    return "-";
                case Keys.Decimal:
                    return ".";
                case Keys.Divide:
                    return "/";
                case Keys.NumLock:
                    return " [NumLock] ";
                case Keys.Scroll:
                    return " [ScrollLock] ";

                case Keys.BrowserBack:
                    return " [🌐⇦] ";
                case Keys.BrowserForward:
                    return " [🌐⇨] ";
                case Keys.BrowserRefresh:
                    return " [🌐↻] ";
                case Keys.BrowserStop:
                    return " [🌐✋] ";
                case Keys.BrowserSearch:
                    return " [🌐🔎] ";
                case Keys.BrowserFavorites:
                    return " [🌐★] ";
                case Keys.BrowserHome:
                    return " [🌐⌂] ";

          
                case Keys.VolumeMute:
                    return " 🔇 ";
                case Keys.VolumeDown:
                    return " 🔉⏬ ";
                case Keys.VolumeUp:
                    return " 🔊⏫ ";
                case Keys.MediaNextTrack:
                    return " ⏭ ";
                case Keys.MediaPreviousTrack:
                    return " ⏮ ";
                case Keys.MediaStop:
                    return " ◼ ";
                case Keys.MediaPlayPause:
                    return " ⏯ ";
                case Keys.LaunchMail:
                    return " 📧 ";
                case Keys.SelectMedia:
                    return " ♪ ";
                case Keys.LaunchApplication1:
                    return " ① ";
                case Keys.LaunchApplication2:
                    return " ② ";

                case Keys.Play:
                    return " ▶ ";
                case Keys.Zoom:
                    return " [🔎±] ";
                

            }
            if(Keys.F1 <= k && k <= Keys.F24)
                return " " + k.ToString() + " ";

            throw new NotImplementedException();
        }
    }
}
