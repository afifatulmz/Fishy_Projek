using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek.Models
{
    public class RuangCooler
    {
        public string idRuang;
        public int idGudang;
        public string namaRuang;
        public double  kapasitasTon;

        public RuangCooler(string idRuang, int idGudang, string namaRuang, double kapasitasTon)
        {
            this.idRuang = idRuang;
            this.idGudang = idGudang;
            this.namaRuang = namaRuang;
            this.kapasitasTon = kapasitasTon;
        }

        public string IdRuang
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

        public double KapasitasTon
        {
            get { return kapasitasTon; }
            set { kapasitasTon = value; }
        }
    }
}