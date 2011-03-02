using System.Collections.Generic;

namespace AnujBank
{
    public class Structures
    {
        private HashSet<Structure> structureSet = new HashSet<Structure>();

        public void Add(Structure structure)
        {
            structureSet.Add(structure);
        }

        public bool Contains(Structure structure)
        {
            return structureSet.Contains(structure);
        }
    }
}