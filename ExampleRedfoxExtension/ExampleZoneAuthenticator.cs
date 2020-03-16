using Redfox.Users;
using Redfox.Zones;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleRedfoxExtension
{
    class ExampleZoneAuthenticator : ZoneAuthenticator
    {
        public override bool GuestLogin(User user)
        {
            int id = new Random().Next(99999);
            string name = "Example" + id;
            this.UpdateUserData(user, id, name, true);
            return true; //allow the user to join the zone
        }

        public override bool Login(User user, string login, string password)
        {
            //Implement login system here
            if(login == "admin" && password == "admin1")
            {
                int id = new Random().Next(99999);
                this.UpdateUserData(user, id, login, true);
                return true; //allow the user to join the zone
            }
            return false; //do not allow the user to join the zone
        }
    }
}
