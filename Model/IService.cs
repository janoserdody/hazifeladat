using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Model
{
    public interface IService
    {
        IList<User> ReadAllDataFromDatabase();

        string GetNextLineFromDatabase();

        User GetUser(int id);

        User GetUserByUserName(string userName);
    }
}
