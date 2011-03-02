using System;

namespace AnujBank
{
    public class Client
    {
        private readonly ClientId clientId;
        private readonly Accounts holdings;
        private readonly Structures structures;

        public Client(ClientId clientId, Accounts holdings)
        {
            this.clientId = clientId;
            this.holdings = holdings;
            structures = new Structures();
        }


        public void AddStructure(Structure structure)
        {
            structures.Add(structure);
        }

        public bool Contains(Structure structure)
        {
            return structures.Contains(structure);
        }
    }
}