using System;

namespace Fishy_Projek
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
                IdIkan = id,
                NamaIkan = nama,
                SuhuIdeal = ideal,
                BatasSuhu = batas
            };

            _repo.TambahIkan(ikanBaru);
            pesanError = "Data ikan baru berhasil disimpan ke database!";
            return true;
        }
    }
}
