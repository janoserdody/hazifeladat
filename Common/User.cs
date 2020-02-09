using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class User
    {
        public int Id
        {
            get; set;
        }

        public string Username
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }

        public string FamilyName
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public DateTime BornDate
        {
            get; set;
        }

        public string BornPlace
        {
            get; set;
        }

        public string ResidenceCity
        {
            get; set;
        }

        public User(int Id, string userName, string password, string familyName, string firstName, DateTime bornDate, string bornPlace, string residenceCity)
        {
            this.Id = Id;
            this.Username = userName;
            this.Password = password;
            this.FamilyName = familyName;
            this.FirstName = firstName;
            this.BornDate = bornDate;
            this.BornPlace = bornPlace;
            this.ResidenceCity = residenceCity;
        }
    }
}
