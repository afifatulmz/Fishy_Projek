using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek
{
    internal class ClassDetailPengiriman
    {
        private string _idPengiriman;
        private int _idStok;
        private double _kuantitasKirim;

        public ClassDetailPengiriman()
        {
            _idPengiriman = string.Empty;
            _idStok = 0;
            _kuantitasKirim = 0;
        }

        public ClassDetailPengiriman(string idPengiriman, int idStok, double kuantitasKirim)
        {
            _idPengiriman = idPengiriman;
            _idStok = idStok;
            _kuantitasKirim = kuantitasKirim;
        }

        public string IdPengiriman
        {
            get { return _idPengiriman; }
            set { _idPengiriman = value; }
        }

        public int IdStok
        {
            get { return _idStok; }
            set { _idStok = value; }
        }

        public double KuantitasKirim
        {
            get { return _kuantitasKirim; }
            set { _kuantitasKirim = value; }
        }

        public override string ToString()
        {
            return $"ID Pengiriman: {IdPengiriman}, ID Stok: {IdStok}, Kuantitas Kirim: {KuantitasKirim} kg";
        }
    }
}
