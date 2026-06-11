using System;

namespace Fishy_Projek
{
    public class OperasionalController
    {
        private OperasionalRepository _repo = new OperasionalRepository();

        
        public void SimpanLogHarian(string idRuang, double suhu, string grade, string catatan)
        {
            BatchIkan b = new BatchIkan
            {
                IdRuang = idRuang,
                SuhuAktualC = suhu,
                GradeMutu = grade,
                Catatan = catatan
            };
            _repo.SimpanBatchIkan(b);
        }

        
        public void ProsesIkanMasuk(string idIkan, string idRuang, double kuantitasMasuk)
        {
            
            _repo.EksekusiFunctionTerimaStok(idIkan, idRuang, kuantitasMasuk);
        }

        
        public bool ProsesKirimBarang(int idStok, double kuantitasKirim, out string statusNotifikasi)
        {
            
            double stokTersedia = _repo.CekKuantitasStok(idStok);

            
            if (kuantitasKirim > stokTersedia)
            {
                statusNotifikasi = $"Transaksi Ditolak! Stok tidak cukup. Saldo saat ini: {stokTersedia} Kg.";
                return false;
            }

            try
            {
                
                _repo.KurangStokDanCatatMutasi(idStok, kuantitasKirim);
                statusNotifikasi = "Sukses! Pengiriman diproses dan histori mutasi berhasil dicatat.";
                return true;
            }
            catch (Exception ex)
            {
                statusNotifikasi = $"Gagal memproses transaksi! Terjadi error: {ex.Message}";
                return false;
            }
        }
    }
}
