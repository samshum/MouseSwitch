using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseSwitch
{
    /// <summary>
    /// 改变鼠标滚轮的使用习惯（Mac：1， Windows：0）
    /// </summary>
    public class SwithWheel
    {
        /// <summary>
        /// 改变鼠标滚轮的使用习惯（Mac：1， Windows：0）
        /// </summary>
        /// <param name="keyvalue"></param>
        public void SetWhell(long keyvalue)
        {
            string keyPath = @"SYSTEM\CurrentControlSet\Enum\HID\";
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(keyPath);
            string[] hids = rk.GetSubKeyNames();
            foreach (string hiditem in hids)
            {
                RegistryKey hidKey = rk.OpenSubKey(hiditem);
                string[] vids = hidKey.GetSubKeyNames();
                foreach(string viditem in vids)
                {
                    RegistryKey dpkey = hidKey.OpenSubKey(viditem + @"\Device Parameters", true);
                    object ffwkey = dpkey.GetValue("FlipFlopWheel");
                    if (ffwkey != null)
                    {
                        dpkey.SetValue("FlipFlopWheel", keyvalue, RegistryValueKind.DWord);
                    }
                    dpkey.Close();
                    dpkey.Dispose();
                }
                hidKey.Close();
                hidKey.Dispose();
            }
            rk.Close();
            rk.Dispose();
        }
    }
}
