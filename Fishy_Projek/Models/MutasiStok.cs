using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek.Models
{
    public class MutasiStok
    {
        private int idMutasi;
        private int idStok;
        private int jenisMutasi;
        private int jumlahKg;

        public MutasiStok(int idMutasi, int idStok, int jenisMutasi, int jumlahKg)
        {
            this.idMutasi = idMutasi;
            this.idStok = idStok;
            this.jenisMutasi = jenisMutasi;
            this.jumlahKg = jumlahKg;
        }
    }
}
