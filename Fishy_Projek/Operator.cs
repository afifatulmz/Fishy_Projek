using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek
{
    public class Operator : User
    {
        public Operator(int idUser, string nama, string password) : base(idUser, nama, password)
        { }

        public override void HakAksesMenu()
        {
            
        }
    }
}
