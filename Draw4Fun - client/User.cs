using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw4Fun___client
{
    class User
    {
        private int id;
        private String username;
        
        public User(int id, String username)
        {
            this.id = id;
            this.username = username;
        }

        private void setId(int id) { this.id = id; }
        private void setUsername(String username) { this.username = username}

        private int getId() { return id; }
        private String getusername() { return username; }
        

    }
}
