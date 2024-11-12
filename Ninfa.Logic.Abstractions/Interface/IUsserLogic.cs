using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ninfa.Common;

namespace Ninfa.Logic.Abstractions.Interface
{
    public interface IUsserLogic
    {
        Task<int> Save(UserSave dto);
        Task<bool> Delete( string phone);
        Task<UserRead> Get(string phone);
    }
}
