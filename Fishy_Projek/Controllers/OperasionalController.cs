using System;
using Fishy_Projek.Models;
using Fishy_Projek.Repositories;
using Npgsql;

namespace Fishy_Projek.Controllers
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

        public void ProsesIkanMasuk(string idIkan, string idRuang, double kuantitasMasuk, int idUser)
        {
            _repo.EksekusiStoredProcedureTerimaStok(idIkan, idRuang, kuantitasMasuk, idUser);
        }

        public bool ProsesKirimBarang(string idPengiriman, int idUser, string tujuan, string noArmada, int idStok, double kuantitasKirim, out string statusNotifikasi)
        {
            try
            {
                _repo.EksekusiStoredProcedurePengiriman(idPengiriman, idUser, tujuan, noArmada, idStok, kuantitasKirim);
                statusNotifikasi = "Sukses! Pengiriman diproses, detail nota dan mutasi berhasil dicatat.";
                return true;
            }
            catch (PostgresException ex) when (ex.SqlState == "P0001")
            {
                statusNotifikasi = "Transaksi Ditolak: " + ex.MessageText;
                return false;
            }
            catch (Exception ex)
            {
                statusNotifikasi = $"Gagal memproses transaksi! Terjadi error: {ex.Message}";
                return false;
            }
        }
    }
}