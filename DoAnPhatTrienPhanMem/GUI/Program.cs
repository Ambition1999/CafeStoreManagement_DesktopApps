using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace GUI
{
    static class Program
    {
        public static Form_GoiMon frmGM = null;
        public static Form_SoDoBan frmSD = null;
        public static Form_ChucNangChinh frmCNC = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            //if ((Program.frmCNC == null || Program.frmCNC.IsDisposed))
            //{
            //    Program.frmCNC = new Form_ChucNangChinh();
            //}
            //Application.Run(frmCNC);
            Application.Run(new Form_Login());
            //Application.Run(new Form_ThongKe());

        }
    }
}
