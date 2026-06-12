using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek.Models
{
    public class Stok
    {
        private string IdStok;
        private int IdIkan;
        private int IdRuang;
        private int KuantitasKg;

    public Stok(string idStok, int idIkan, int idRuang, int kuantitasKg)
        {
            this.IdStok = idStok;
            this.IdIkan = idIkan;
            this.IdRuang = idRuang;
            this.KuantitasKg = kuantitasKg;
        }
    }
}
