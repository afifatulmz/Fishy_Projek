using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek
{
    public class Stok
    {
        private int idStok;
        private int idIkan;
        private int idRuang;
        private int kuantitasKg;

    public Stok(int idStok, int idIkan, int idRuang, int kuantitasKg)
        {
            this.idStok = idStok;
            this.idIkan = idIkan;
            this.idRuang = idRuang;
            this.kuantitasKg = kuantitasKg;
        }
    }
}
