using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek.Models
{
    public class Manager : User
    {
        public Manager(int idUser, string nama, string username, string password, int idRole) : base(idUser, nama, username, password, idRole) 
        { }

        public override void HakAksesMenu()
        {
            
        }
       
    }
}
