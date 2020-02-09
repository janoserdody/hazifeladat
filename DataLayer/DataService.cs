using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataLayer
{
    public class DataService : IDataService
    {
        private string[] lines;

        private IList<User> userList = new List<User>();

        private int index = 0;

        IList<User> IDataService.GetAllUserData()
        {
            lines = System.IO.File.ReadAllLines(@"adatok.csv");

            foreach (var line in lines)
            {
                string[] userData = line.Split(',');

                User user = new User(
                    Convert.ToInt32(userData[0]),
                    userData[1],
                    userData[2],
                    userData[3],
                    userData[4],
                    Convert.ToDateTime(userData[5]),
                    userData[6],
                    userData[7]);

                userList.Add(user);
            }

            return userList;
        }

        string IDataService.GetNextLine()
        {
            return lines[index++];
        }

        int IDataService.GetUserCount()
        {
            return userList.Count();
        }

        User IDataService.ReadUser(int id)
        {
            if (id >= userList.Count)
            {
                throw new IndexOutOfRangeException("There is no user at this index");
            }

            return userList[id];
        }
    }
}
