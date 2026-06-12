using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek.Models
{
    public abstract class User
    {
        private int idUser { get; set; }
        private string? Nama { get; set; }
        private string? Password { get; set; }
        private int idRole { get; set; }



        public User(int idUser, string nama, string password, int idRole)
        {
            this.idUser = idUser;
            this.Nama = Nama;
            this.Password = Password;
            this.idRole = idRole;
        }

        public abstract void HakAksesMenu();
        




    }
}
