using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek.Models
{
    public class Gudang
    {
        private int idGudang;
        private string namaGudang;
        private string lokasiGudang;

        public Gudang(int idGudang, string namaGudang, string lokasiGudang)
        {
            this.idGudang = idGudang;
            this.namaGudang = namaGudang;
            this.lokasiGudang = lokasiGudang;
        }

        public int IdGudang
        {
            get { return idGudang; }
            set { idGudang = value; }
        }

        public string NamaGudang
        {
            get { return namaGudang; }
            set { namaGudang = value; }
        }

        public string LokasiGudang
        {
            get { return lokasiGudang; }
            set { lokasiGudang = value; }
        }
    }
}