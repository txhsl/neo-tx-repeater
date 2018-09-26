using Neo.Core;
using Neo.Implementations.Blockchains.LevelDB;
using Neo.Implementations.Wallets.EntityFramework;
using Neo.Implementations.Wallets.NEP6;
using Neo.Network;
using System;
using repeater_gui.Properties;

namespace repeater_gui
{
    static class Program
    {
        public static LocalNode LocalNode;
        public static NEP6Wallet CurrentWallet;
        public static MainWindow MainWindow;

        ///<summary>
        /// 应用程序的主入口点。
        ///</summary>
        [STAThread]
        static void Main(string[] args)
        {
            using (Blockchain.RegisterBlockchain(new LevelDBBlockchain(Settings.Default.DataDirectoryPath)))
            using (LocalNode = new LocalNode())
            {
                LocalNode.UpnpEnabled = true;
                App app = new App();
                app.InitializeComponent();
                app.MainWindow = MainWindow ;
                app.Run();
            }
        }
    }
}
