using System;

namespace Fishy_Projek.Models
{
    public class DetailPengiriman
    {
        public string? IdPengiriman { get; set; }
        public int IdStok { get; set; }
        public double KuantitasKirim { get; set; }

        public DetailPengiriman() { }

        public DetailPengiriman(string idPengiriman, int idStok, double kuantitasKirim)
        {
            this.IdPengiriman = idPengiriman;
            this.IdStok = idStok;
            this.KuantitasKirim = kuantitasKirim;
        }

        public override string ToString()
        {
            return $"ID Pengiriman: {IdPengiriman}, ID Stok: {IdStok}, Kuantitas Kirim: {KuantitasKirim} kg";
        }
    }
}