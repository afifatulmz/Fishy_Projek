using System;

namespace Fishy_Projek.Models
{
    public class Ikan
    {
        public string? IdIkan { get; set; }
        public string? NamaIkan { get; set; }
        public double SuhuIdeal { get; set; }
        public double BatasSuhu { get; set; }

        public Ikan() { }

        public Ikan(string idIkan, string namaIkan, double suhuIdeal, double batasSuhu)
        {
            this.IdIkan = idIkan;
            this.NamaIkan = namaIkan;
            this.SuhuIdeal = suhuIdeal;
            this.BatasSuhu = batasSuhu;
        }


    }
}
