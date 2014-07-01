using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MediaManagerPUL;

namespace MediaManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitSetting();

            frmStart frm = new frmStart();
            frm.ShowDialog();

            Application.Run(new frmMain());
        }
        /// <summary>
        /// 初始化设置.
        /// </summary>
        static void InitSetting()
        {
            CommonServer.UTorrentUserName = MediaManager.Properties.Settings.Default.UTorrentUserName;
            CommonServer.UTorrentPassWord = MediaManager.Properties.Settings.Default.UTorrentPassWord;
            CommonServer.UTorrentConnectUrl = MediaManager.Properties.Settings.Default.UTorrentConnectUrl;
        }
    }
}
