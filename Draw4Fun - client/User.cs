using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw4Fun___client
{
    public class User
    {
        private static User user = new User();
        public static int id;
        public static String nickname;

        private User(){}

        public static User getUser() { return user; }
    }
}
