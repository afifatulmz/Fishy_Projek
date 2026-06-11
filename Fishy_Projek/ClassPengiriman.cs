using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek
{
    internal class ClassPengiriman
    {
        private string _idPengiriman;
        private int _idUser;
        private DateTime _waktuKirim;
        private string _tujuan;
        private string _noArmada;
        private List<string> _detailStokBawaan;

        public ClassPengiriman()
        {
            _idPengiriman = string.Empty;
            _idUser = 0;
            _waktuKirim = DateTime.Now;
            _tujuan = string.Empty;
            _noArmada = string.Empty;
            _detailStokBawaan = new List<string>();
        }

        public ClassPengiriman(string idPengiriman, int idUser, DateTime waktuKirim,
                                string tujuan, string noArmada, List<string> detailStokBawaan)
        {
            _idPengiriman = idPengiriman;
            _idUser = idUser;
            _waktuKirim = waktuKirim;
            _tujuan = tujuan;
            _noArmada = noArmada;
            _detailStokBawaan = detailStokBawaan;
        }

        public string IdPengiriman
        {
            get { return _idPengiriman; }
            set { _idPengiriman = value; }
        }

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        public DateTime WaktuKirim
        {
            get { return _waktuKirim; }
            set { _waktuKirim = value; }
        }

        public string Tujuan
        {
            get { return _tujuan; }
            set { _tujuan = value; }
        }

        public string NoArmada
        {
            get { return _noArmada; }
            set { _noArmada = value; }
        }

        public List<string> DetailStokBawaan
        {
            get { return _detailStokBawaan; }
            set { _detailStokBawaan = value; }
        }

        public void TambahDetail(string idStok)
        {
            _detailStokBawaan.Add(idStok);
        }

        public bool HapusDetail(string idStok)
        {
            return _detailStokBawaan.Remove(idStok);
        }

        public override string ToString()
        {
            return $"ID: {_idPengiriman} | Tujuan: {_tujuan} | Armada: {_noArmada} | Waktu: {_waktuKirim:dd/MM/yyyy HH:mm} | Stok: {_detailStokBawaan.Count} item";
        }
    }
}
