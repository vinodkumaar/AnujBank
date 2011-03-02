using System;

namespace AnujBank
{
    public class Accounts
    {
        private readonly Account[] _accounts;

        public Accounts(params Account[] accounts)
        {
            _accounts = accounts;
        }

        public int Count
        {
            get { return _accounts.Length; }
        }
    }
}