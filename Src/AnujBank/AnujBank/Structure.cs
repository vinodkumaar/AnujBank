using System;

namespace AnujBank
{
    public class Structure
    {
        private readonly ClientAccounts sourceClientAccounts;

        public Structure(ClientAccounts sourceClientAccounts)
        {
            if(sourceClientAccounts.Count < 2) throw new ArgumentException("A structure must have at least 2 source accounts.");
            this.sourceClientAccounts = sourceClientAccounts;
        }
    }
}
