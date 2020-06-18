using System;
using System.Collections.Generic;

namespace EFTest.Models
{
    public partial class Bestuursleden
    {
        public int Spelersnr { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime? EindDatum { get; set; }
        public string Functie { get; set; }

        public virtual Spelers SpelersnrNavigation { get; set; }
    }
}
