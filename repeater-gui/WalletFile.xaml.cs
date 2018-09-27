using Microsoft.Win32;
using System;
using System.Windows;

namespace repeater_gui
{
    /// <summary>
    /// WalletFile.xaml 的交互逻辑
    /// </summary>
    public partial class WalletFile : Window
    {
        public string walletPathA { get; set; }
        public string walletPasswordA { get; set; }

        public string walletPathB { get; set; }
        public string indexerPathB { get; set; }
        public string walletPasswordB { get; set; }

        public WalletFile()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            walletPathA = this.txtWalletPathA.Text;
            IntPtr pA = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(this.txtbxPasswordA.SecurePassword);
            walletPasswordA = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(pA);

            walletPathB = this.txtWalletPathB.Text;
            IntPtr pB = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(this.txtbxPasswordB.SecurePassword);
            walletPasswordB = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(pB);

            if (walletPasswordA == "" || walletPasswordB == "" || walletPathA == "" || walletPathB == "")
            {
                MessageBox.Show("请输入完整信息！");
            }
            else
            {
                this.DialogResult = true;
            }
        }

        private void btnFileA_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "请选择钱包文件";
            dlg.DefaultExt = ".db3";
            dlg.Filter = "全部文件类型|*.*|(*.db3)|*.db3|(*.json)|*.json";

            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                this.txtWalletPathA.Text = dlg.FileName;
            }
        }

        private void btnFileB_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "请选择钱包文件"; 
            dlg.DefaultExt = ".db3";
            dlg.Filter = "全部文件类型|*.*|(*.db3)|*.db3|(*.json)|*.json";

            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                this.txtWalletPathB.Text = dlg.FileName;
            }
        }

        private void btnIndexer_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "请选择索引文件";
            dlg.DefaultExt = ".*";

            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                this.txtWalletPathB.Text = dlg.FileName;
            }
        }
    }
}
