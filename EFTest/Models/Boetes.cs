using System;
using System.Collections.Generic;

namespace EFTest.Models
{
    public partial class Boetes
    {
        public int Betalingsnr { get; set; }
        public int Spelersnr { get; set; }
        public DateTime Datum { get; set; }
        public decimal Bedrag { get; set; }

        public virtual Spelers SpelersnrNavigation { get; set; }
    }
}
