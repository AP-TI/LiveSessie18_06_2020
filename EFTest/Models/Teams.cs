using System;
using System.Collections.Generic;

namespace EFTest.Models
{
    public partial class Teams
    {
        public Teams()
        {
            Wedstrijden = new HashSet<Wedstrijden>();
        }

        public int Teamnr { get; set; }
        public int Spelersnr { get; set; }
        public string Divisie { get; set; }

        public virtual Spelers SpelersnrNavigation { get; set; }
        public virtual ICollection<Wedstrijden> Wedstrijden { get; set; }
    }
}
