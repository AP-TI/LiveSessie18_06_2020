using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deel3Oefening5
{
    internal class Speler
    {
        #region Members

        private int _spelerNr;
        private string _spelerNaam;
        private string _spelerVoorletters;
        private DateTime _spelerGeboorteDatum;
        private char _spelerGeslacht;
        private int _spelerJaartoe;
        private string _spelerStraat;
        private string _spelerHuisNr;
        private string _spelerPostcode;
        private string _spelerPlaats;
        private string _spelerTelefoon;
        private string _spelerBondsNr;
        private List<Boete> _spelerBoetes;

        #endregion

        #region Properties

        public int Nummer
        {
            get 
            {
                return _spelerNr;
            }
            set
            {
                _spelerNr = value;
            }
        }

        public string Naam
        {
            get
            {
                return _spelerNaam;
            }
            set
            {
                _spelerNaam = value;
            }
        }

        public string Voorletters
        {
            get
            {
                return _spelerVoorletters;
            }
            set
            {
                _spelerVoorletters = value;
            }
        }

        public DateTime GeboorteDatum
        {
            get
            {
                return _spelerGeboorteDatum;
            }
            set
            {
                _spelerGeboorteDatum = value;
            }
        }

        public char Geslacht
        {
            get
            {
                return _spelerGeslacht;
            }
            set
            {
                _spelerGeslacht = value;
            }
        }

        public int JaarToetreding
        {
            get
            {
                return _spelerJaartoe;
            }
            set
            {
                _spelerJaartoe = value;
            }
        }

        public string Straat
        {
            get
            {
                return _spelerStraat;
            }
            set
            {
                _spelerStraat = value;
            }
        }

        public string HuisNr
        {
            get
            {
                return _spelerHuisNr;
            }
            set
            {
                _spelerHuisNr = value;
            }
        }

        public string Postcode
        {
            get
            {
                return _spelerPostcode;
            }
            set
            {
                _spelerPostcode = value;
            }
        }

        public string Plaats
        {
            get
            {
                return _spelerPlaats;
            }
            set
            {
                _spelerPlaats = value;
            }
        }

        public string Telefoon
        {
            get
            {
                return _spelerTelefoon;
            }
            set
            {
                _spelerTelefoon = value;
            }
        }

        public string BondsNr
        {
            get
            {
                return _spelerBondsNr;
            }
            set
            {
                _spelerBondsNr = value;
            }
        }

        public List<Boete> Boetes
        {
            get
            {
                return _spelerBoetes;
            }
            set
            {
                _spelerBoetes = value;
            }
        }

        public override string ToString()
        {
            return $"Naam: {Naam}";
        }

        #endregion


    }
}
