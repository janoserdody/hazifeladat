using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataLayer
{
    public interface IDataService
    {
        IList<User> GetAllUserData();

        string GetNextLine();

        User ReadUser(int id);

        int GetUserCount();
    }
}
