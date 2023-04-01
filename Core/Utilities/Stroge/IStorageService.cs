using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Storage
{
    public interface IStorageService : IStorage
    {
        string StrogeName { get; }
    }
}