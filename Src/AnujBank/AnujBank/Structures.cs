using System;
using System.Collections.Generic;
using System.Linq;

namespace AnujBank
{
    public class Structures
    {
        private HashSet<Structure> structureSet = new HashSet<Structure>();

        public void Add(Structure structure)
        {
            if (HasOverlappingAccount(structure)) throw new ArgumentException("Cannot add two structure containing same accounts.");
            structureSet.Add(structure);
        }

        private bool HasOverlappingAccount(Structure newStructure)
        {
            return structureSet.Any(structure => structure.SharesASourceAccountWith(newStructure));
        }

        public bool Contains(Structure structure)
        {
            return structureSet.Contains(structure);
        }
    }
}