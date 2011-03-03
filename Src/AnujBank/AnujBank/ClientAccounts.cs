using System;

namespace AnujBank
{
    public class ClientAccounts
    {
        private readonly Account[] _accounts;

        public ClientAccounts(params Account[] accounts)
        {
            _accounts = accounts;
        }

        public int Count
        {
            get { return _accounts.Length; }
        }
    }
}