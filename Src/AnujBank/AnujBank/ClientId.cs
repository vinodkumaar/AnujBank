﻿using System.Text.RegularExpressions;

namespace AnujBank
{
    public class ClientId
    {
        public ClientId(string id)
        {

            Id = id;
            Validate();
        }

        public string Id { get; set; }

        public bool Equals(ClientId other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Id, Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ClientId)) return false;
            return Equals((ClientId)obj);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }
        private void Validate()
        {
            var regEx = new Regex("^[A-Z]{3}[0-9]{3}$");
            if (!regEx.IsMatch(Id)) throw new InvalidClientIdException("Invalid Client Id");

        }
      
        public ClientId(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
     
    }
}