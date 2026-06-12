using System.Data;
using Fishy_Projek.Helpers;
using Npgsql;

namespace Fishy_Projek.Repositories
{
    public class LaporanRepository
    {
        public DataTable AmbilRingkasanStokView() 
        {
            DataTable dt = new DataTable();
            using (var conn = DbHelper.GetConnection()) 
            {
                conn.Open();
                string query = "SELECT * FROM public.vw_ringkasan_stok";
                using (var cmd = new NpgsqlCommand(query, conn)) 
                {
                    using (var da = new NpgsqlDataAdapter(cmd)) { da.Fill(dt);  }
                }
            }
            return dt;
        }

        public DataTable AmbilRiwayatMutasiLengkapView()
        {
            DataTable dt = new DataTable();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM public.vw_riwayat_mutasi_lengkap";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var da = new NpgsqlDataAdapter(cmd)) { da.Fill(dt); }
                }
            }
            return dt;
        }

    }
}
