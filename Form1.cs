using Microsoft.Win32;
using MouseSwitch.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseSwitch
{
    public enum MouseState { left, right };
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getInitMouseState();
            getInitSysState();
        }

        //-------------------------------------------设置跟随系统系统一起启动-----------------------------------

        #region 注册表操作相关
        /// <summary>
        /// 注册表路径
        /// </summary>
        private string keyPath = @"Software\Microsoft\Windows\CurrentVersion\Run";

        /// <summary>
        /// 注册表键名
        /// </summary>
        private string keyName = "MouseSwitchApplication";

        /// <summary>
        /// 设置是否随系统启动，true:跟随系统启动，false：反之
        /// </summary>
        /// <param name="isStart">设置是否随系统启动</param>
        private bool setStartBySystem(bool isStart)
        {
            bool result = false;
            try
            {
                string path = Application.ExecutablePath;
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rkmain = rk.CreateSubKey(keyPath);

                if (isStart)
                {
                    rkmain.SetValue(keyName, path);
                    result = true;
                }
                else
                {
                    rkmain.DeleteValue(keyName, false);
                    result = false;
                }
                rkmain.Close();
                rk.Close();
                return result;
            }
            catch { }
            return result;
        }

        /// <summary>
        /// 获取当前注册表写入状态的值
        /// </summary>
        /// <returns></returns>
        private string getStartBySystem()
        {
            string path = Application.ExecutablePath;
            RegistryKey rk = Registry.LocalMachine;
            RegistryKey rkopen = rk.OpenSubKey(keyPath);
            string getResult = rkopen.GetValue(keyName) as String;
            rk.Close();
            rkopen.Close();
            return getResult;
        }

        #endregion

        /// <summary>
        /// 系统启动初始化启动菜单状态
        /// </summary>
        private void getInitSysState()
        {
            if (string.IsNullOrWhiteSpace(getStartBySystem()))
            {
                checkbox1.Image = global::MouseSwitch.Properties.Resources.block;
                checkbox1.ToolTipText = "当前状态：不随系统启动";
            }
            else
            {
                checkbox1.Image = global::MouseSwitch.Properties.Resources.accept;
                checkbox1.ToolTipText = "当前状态：随系统启动";
            }
        }

        private void 随系统启动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置开机自启动，需要修改注册表", "提示"
            setStartBySystem(true);
            checkbox1.Image = global::MouseSwitch.Properties.Resources.accept;
            checkbox1.ToolTipText = "当前状态：随系统启动";
        }


        //--------------------------------------------切换鼠标使用习惯操作-------------------------------------------
        #region 鼠标使用习惯切换操作
        [DllImport("user32.dll")]
        private extern static bool SwapMouseButton(bool fSwap);
  
        [DllImport("user32.dll")]
        private extern static int GetSystemMetrics(int index);

        /// <summary>
        /// 系统启动时获取并呈现当前鼠标使用状态
        /// </summary>
        private void getInitMouseState()
        {
            int flag = GetSystemMetrics(23);//获取当前鼠标设置状态
            if (flag == 0)//右手习惯
            {
                setMouseOperation(MouseState.right);
            }
            else
            {
                setMouseOperation(MouseState.left);
            }
        }

        /// <summary>
        /// 自动切换鼠标使用状态
        /// </summary>
        private void switchMouseOperation()
        {
            int flag = GetSystemMetrics(23);//获取当前鼠标设置状态
            if (flag == 0)//右手习惯
            {
                setMouseOperation(MouseState.left);
            }
            else
            {
                setMouseOperation(MouseState.right);
            }
        }
        #endregion

        /// <summary>
        /// 设置鼠标左右手使用习惯
        /// </summary>
        /// <param name="mouseState"></param>
        private void setMouseOperation(MouseState mouseState)
        {
            if (mouseState == MouseState.left)
            {
                SwapMouseButton(true);//设置成左手
                notifyIcon1.Icon = Resources.mouse_left;
                notifyIcon1.Text = "当前：左手习惯";
            }
            else if (mouseState == MouseState.right)
            {
                SwapMouseButton(false);//设置成右手
                notifyIcon1.Icon = Resources.mouse_right;
                notifyIcon1.Text = "当前：右手习惯";
            }
        }

        /// <summary>
        /// 双击切换鼠标使用习惯
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switchMouseOperation();
        }

        private void 左手习惯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setMouseOperation(MouseState.left);
        }

        private void 右手习惯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setMouseOperation(MouseState.right);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void MAC操作习惯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setWheel(1);
        }

        private void Windows操作习惯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setWheel(0);
        }

        private void setWheel(long keyvalue)
        {
            new SwithWheel().SetWhell(keyvalue);
            MessageBox.Show("鼠标使用习惯标识已更新，请断开鼠标重新链接即可生效！", "鼠标滚轮方向设置成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }


    }
}
