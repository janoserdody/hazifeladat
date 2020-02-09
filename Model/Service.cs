using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DataLayer;

namespace Model
{
    public class Service : IService
    {
        private IDataService dataService;

        private IList<User> userList;

        public Service()
        {
            dataService = new DataService();
        }

        string IService.GetNextLineFromDatabase()
        {
            return dataService.GetNextLine();
        }

        User IService.GetUser(int id)
        {
            try
            {
                return dataService.ReadUser(id);
            }
            catch(IndexOutOfRangeException ex)
            {
                throw new IndexOutOfRangeException(ex.Message);
            }
        }

        User GetUser(int Id)
        {
            return ((IService)this).GetUser(Id);
        }

        User IService.GetUserByUserName(string userName)
        {
            User user = null;

            int maxIndex = dataService.GetUserCount();

            int index = 0;

            while (index < maxIndex)
            {
                user = dataService.ReadUser(index);

                if (user.Username == userName)
                {
                    break;
                }

                index++;

            }

            return user;
        }

        IList<User> IService.ReadAllDataFromDatabase()
        {
            userList = dataService.GetAllUserData();

            return userList;
        }
    }
}
