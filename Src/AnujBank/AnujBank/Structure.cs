using System;

namespace AnujBank
{
    public class Structure
    {
        private readonly Accounts sourceAccounts;

        public Structure(Accounts sourceAccounts)
        {
            if(sourceAccounts.Count < 2) throw new ArgumentException("A structure must have at least 2 source accounts.");
            this.sourceAccounts = sourceAccounts;
        }
    }
}
