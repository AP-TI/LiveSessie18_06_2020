using System;
using System.Collections.Generic;

namespace EFTest.Models
{
    public partial class Wedstrijden
    {
        public int Wedstrijdnr { get; set; }
        public int Teamnr { get; set; }
        public int Spelersnr { get; set; }
        public short Gewonnen { get; set; }
        public short Verloren { get; set; }

        public virtual Spelers SpelersnrNavigation { get; set; }
        public virtual Teams TeamnrNavigation { get; set; }
    }
}
