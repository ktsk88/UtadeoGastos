using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninfa.Logic.Abstractions.Interface
{
    public interface UserWorkingLogic
    {
        Task AddDataValue(decimal value, int conceptId);
    }
}
