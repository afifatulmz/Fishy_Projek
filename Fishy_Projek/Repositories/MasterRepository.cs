using System;
using System.Data;
using Fishy_Projek.Helpers;
using Fishy_Projek.Models;
using Npgsql;

namespace Fishy_Projek.Repositories
{
    public class MasterRepository
    {
        // === MANAGEMENT DATA IKAN ===
        public DataTable AmbilSemuaIkan()
        {
            DataTable dt = new DataTable();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_ikan, nama_ikan, suhu_ideal, batas_suhu FROM public.ikan ORDER BY id_ikan";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var da = new NpgsqlDataAdapter(cmd)) { da.Fill(dt); }
                }
            }
            return dt;
        }

        public void TambahIkan(Ikan ikan)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO public.ikan (id_ikan, nama_ikan, suhu_ideal, batas_suhu) VALUES (@id, @nama, @ideal, @batas)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", ikan.IdIkan ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@nama", ikan.NamaIkan ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ideal", ikan.SuhuIdeal);
                    cmd.Parameters.AddWithValue("@batas", ikan.BatasSuhu);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // === MANAGEMENT DATA GUDANG ===
        public DataTable AmbilSemuaGudang()
        {
            DataTable dt = new DataTable();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_gudang, nama_gudang, lokasi_gudang FROM public.gudang ORDER BY id_gudang";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var da = new NpgsqlDataAdapter(cmd)) { da.Fill(dt); }
                }
            }
            return dt;
        }

        // === MANAGEMENT DATA RUANG COOLER ===
        // Dipakai untuk mengisi pilihan ComboBox Ruangan di Form
        public DataTable AmbilRuanganPerGudang(int idGudang)
        {
            DataTable dt = new DataTable();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_ruang, nama_ruang, kapasitas_ton FROM public.ruang_cooler WHERE id_gudang = @idGudang";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idGudang", idGudang);
                    using (var da = new NpgsqlDataAdapter(cmd)) { da.Fill(dt); }
                }
            }
            return dt;
        }
    }
}