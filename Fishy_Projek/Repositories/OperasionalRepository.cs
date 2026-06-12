using Fishy_Projek.Helpers;
using Fishy_Projek.Models;
using Npgsql;
using System;
using System.Data;

namespace Fishy_Projek.Repositories
{
    public class OperasionalRepository
    {
        // 1. INPUT LOG SUHU HARIAN
        public void SimpanBatchIkan(BatchIkan batch)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO public.batch_ikan (id_ruang, suhu_aktual, grade_mutu, catatan) VALUES (@idRuang, @suhu, @grade, @catatan)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idRuang", batch.IdRuang ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@suhu", batch.SuhuAktualC);
                    cmd.Parameters.AddWithValue("@grade", batch.GradeMutu ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@catatan", batch.Catatan ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 2. TRANSAKSI IKAN MASUK (sp_terima_stok)
        public void EksekusiStoredProcedureTerimaStok(string idIkan, string idRuang, double jml, int idUser)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT public.sp_terima_stok(@idIkan, @idRuang, @jml, @idUser)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idIkan", idIkan ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@idRuang", idRuang ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@jml", jml);
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 3. TRANSAKSI PENGIRIMAN KELUAR (sp_proses_pengiriman)
        public void EksekusiStoredProcedurePengiriman(string idPengiriman, int idUser, string tujuan, string noArmada, int idStok, double kuantitas)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "CALL public.sp_proses_pengiriman(@id_p, @id_u, @tujuan, @armada, @id_s, @qty)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_p", idPengiriman);
                    cmd.Parameters.AddWithValue("@id_u", idUser);
                    cmd.Parameters.AddWithValue("@tujuan", tujuan);
                    cmd.Parameters.AddWithValue("@armada", noArmada);
                    cmd.Parameters.AddWithValue("@id_s", idStok);
                    cmd.Parameters.AddWithValue("@qty", kuantitas);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}