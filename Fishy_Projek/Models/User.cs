using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek.Models
{
    public abstract class User
    {
        public int idUser { get; set; }
        public string? Nama { get; set; }
        public string Username { get; set; }
        public string? Password { get; set; }
        public int idRole { get; set; }



        public User(int idUser, string nama, string username, string password, int idRole)
        {
            this.idUser = idUser;
            this.Nama = nama;
            this.Username = username;
            this.Password = password;
            this.idRole = idRole;
        }

        public abstract void HakAksesMenu();
        




    }
}
