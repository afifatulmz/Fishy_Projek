using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek
{
    public class RuangCooler
    {
        private int idRuang;
        private int idGudang;
        private string namaRuang;
        private decimal kapasitasTon;

        public RuangCooler(int idRuang, int idGudang, string namaRuang, decimal kapasitasTon)
        {
            this.idRuang = idRuang;
            this.idGudang = idGudang;
            this.namaRuang = namaRuang;
            this.kapasitasTon = kapasitasTon;
        }

        public int IdRuang
        {
            get { return idRuang; }
            set { idRuang = value; }
        }

        public int IdGudang
        {
            get { return idGudang; }
            set { idGudang = value; }
        }

        public string NamaRuang
        {
            get { return namaRuang; }
            set { namaRuang = value; }
        }

        public decimal KapasitasTon
        {
            get { return kapasitasTon; }
            set { kapasitasTon = value; }
        }
    }
}