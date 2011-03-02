using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnujBank
{
    public interface IRepository
    {
        void Save(Account account);
    }
}
