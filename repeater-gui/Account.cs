using Neo.Implementations.Wallets.EntityFramework;
using Neo.Implementations.Wallets.NEP6;
using Neo.Wallets;

namespace repeater_gui
{

    public class Account
    {
        public string Address { get; set; }
        public string Walletpath { get; set; }
        public string Indexerpath { get; set; }
        public string Password { get; set; }

        private NEP6Wallet wallet;

        //private WalletIndexer indexer;

        public NEP6Wallet Wallet
        {
            get { return wallet; }
            set { wallet = value; }
        }

        //public WalletIndexer Indexer
        //{
        //    get { return indexer; }
        //    set { indexer = value; }
        //}

        public Account()
        {
        }

        public Account(string indexerpath, string walletpath, string password)
        {
            Walletpath = walletpath;
            Indexerpath = Indexerpath;
            //indexer = new WalletIndexer(indexerpath);
            //wallet = UserWallet.Open(walletpath, password);
            wallet = new NEP6Wallet(walletpath);
            wallet.Unlock(password);
            foreach (WalletAccount account in wallet.GetAccounts())
            {
                Address = account.Address;
            }
            Password = password;
        }

        public void Init(string indexerpath, string walletpath, string password)
        {
            Walletpath = walletpath;
            Indexerpath = indexerpath;
            //indexer = new WalletIndexer(indexerpath);
            //wallet = UserWallet.Open(walletpath, password);
            wallet = new NEP6Wallet(walletpath);
            wallet.Unlock(password);
            foreach (WalletAccount account in wallet.GetAccounts())
            {
                Address = account.Address;
            }
            Password = password;
        }
    }


}
