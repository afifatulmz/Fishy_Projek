using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek
{
    public class BatchIkan
    {
        private int idBatch;
        private int idUser;
        private int waktuKirim;
        private string tujuan;
        private string noArmada;
        
    
        public BatchIkan(int idBatch, int idUser, int waktuKirim, string tujuan, string noArmada) 
        {
            this.idBatch = idBatch;
            this.idUser = idUser;
            this.waktuKirim = waktuKirim;
            this.tujuan = tujuan;
            this.noArmada = noArmada;
        }

    }
}
