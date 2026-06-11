using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek
{
    public class Manager : User
    {
        public Manager(int idUser, string nama, string password, int idRole) : base(idUser, nama, password, idRole) 
        { }

        public override void HakAksesMenu()
        {
            
        }
       
    }
}
