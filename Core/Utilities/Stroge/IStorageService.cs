using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Stroge
{
    public interface IStorageService : IStorage
    {
        string StrogeName { get; }
    }
}