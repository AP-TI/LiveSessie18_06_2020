using System;
using System.Collections.Generic;

namespace EFTest.Models
{
    public partial class Spelers
    {
        public Spelers()
        {
            Bestuursleden = new HashSet<Bestuursleden>();
            Boetes = new HashSet<Boetes>();
            Teams = new HashSet<Teams>();
            Wedstrijden = new HashSet<Wedstrijden>();
        }

        public int Spelersnr { get; set; }
        public string Naam { get; set; }
        public string Voorletters { get; set; }
        public DateTime? GebDatum { get; set; }
        public string Geslacht { get; set; }
        public short Jaartoe { get; set; }
        public string Straat { get; set; }
        public string Huisnr { get; set; }
        public string Postcode { get; set; }
        public string Plaats { get; set; }
        public string Telefoon { get; set; }
        public string Bondsnr { get; set; }

        public virtual ICollection<Bestuursleden> Bestuursleden { get; set; }
        public virtual ICollection<Boetes> Boetes { get; set; }
        public virtual ICollection<Teams> Teams { get; set; }
        public virtual ICollection<Wedstrijden> Wedstrijden { get; set; }
    }
}
