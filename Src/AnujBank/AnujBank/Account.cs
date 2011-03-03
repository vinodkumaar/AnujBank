using System;

namespace AnujBank
{
    public class Account
    {

        public Account(AccountId id, ClientId clientId)
        {
            if (clientId == null)
                throw new ArgumentException("You must provide client");
            AccountNo = id;
            ClientId = clientId;

        }
        private AccountId AccountNo { get;  set; }
        private ClientId ClientId { get;  set; }
        public double Balance { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public int GetAccountNumber()
        {
            return AccountNo.Id;
        }
        public string GetClientId()
        {

            return ClientId.Id;
        }

        public bool Equals(Account other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.AccountNo, AccountNo) && Equals(other.ClientId, ClientId);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Account)) return false;
            return Equals((Account)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = (AccountNo != null ? AccountNo.GetHashCode() : 0);
                result = (result * 397) ^ (ClientId != null ? ClientId.GetHashCode() : 0);
                result = (result * 397) ^ Balance.GetHashCode();
                result = (result * 397) ^ LastUpdatedDate.GetHashCode();
                return result;
            }
        }

    }
}
