using System.Text.RegularExpressions;

namespace AnujBank
{
    public class AccountId
    {

        public AccountId(int id)
        {
            Id = id;
            Validate();
        }
        public int Id { get; set; }

        public bool Equals(AccountId other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.Id == Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(AccountId)) return false;
            return Equals((AccountId)obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
        private void Validate()
        {
            var regEx = new Regex("^[0-9]{8}$");
            if (!regEx.IsMatch(Id.ToString())) throw new InvalidAccountIdException("Invalid Account Id");
        }
    }
}