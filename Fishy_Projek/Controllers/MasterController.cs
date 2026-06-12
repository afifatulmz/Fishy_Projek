using Fishy_Projek.Models;
using System;
using Fishy_Projek.Repositories;

namespace Fishy_Projek.Controllers
{
    public class MasterController
    {
        private MasterRepository _repo = new MasterRepository();

        
        public bool ValidasiDanTambahIkan(string id, string nama, double ideal, double batas, out string pesanError)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nama))
            {
                pesanError = "ID Ikan dan Nama Ikan wajib diisi!";
                return false;
            }

            
            Ikan ikanBaru = new Ikan
            {
                idIkan = id,
                namaIkan = nama,
                suhuIdeal = ideal,
                batasSuhu = batas
            };

            _repo.TambahIkan(ikanBaru);
            pesanError = "Data ikan baru berhasil disimpan ke database!";
            return true;
        }
    }
}
