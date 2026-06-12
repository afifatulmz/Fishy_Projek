using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek.Models
{
    public class BatchIkan
    {
        public int IdBatch { get; set; }
        public string? IdRuang { get; set; }
        public DateTime WaktuCek { get; set; }
        public double SuhuAktualC { get; set; }
        public string? GradeMutu { get; set; }
        public string? Catatan { get; set; }

        public BatchIkan() { }


        public BatchIkan(int idBatch, string idRuang, DateTime waktuCek, double suhuAktualC, string gradeMutu, string catatan) 
        {
            this.IdBatch = idBatch;
            this.IdRuang = idRuang;
            this.WaktuCek = waktuCek;
            this.SuhuAktualC = suhuAktualC;
            this.GradeMutu = gradeMutu;
            this.Catatan = catatan;
        }

      
    }
}
