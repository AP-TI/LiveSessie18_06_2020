using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deel3Oefening5
{
    internal class Boete
    {
        #region Members

        private int _boeteBetalingsNr;
        private int _boeteSpelersNr;
        private DateTime _boeteDatum;
        private decimal _boeteBedrag;

        #endregion

        #region Properties

        public int BetalingsNr
        {
            get
            {
                return _boeteBetalingsNr;
            }
            set
            {
                _boeteBetalingsNr = value;
            }
        }

        public int SpelersNr
        {
            get
            {
                return _boeteSpelersNr;
            }
            set
            {
                _boeteSpelersNr = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return _boeteDatum;
            }
            set
            {
                _boeteDatum = value;
            }
        }

        public decimal Bedrag
        {
            get
            {
                return _boeteBedrag;
            }
            set
            {
                _boeteBedrag = value;
            }
        }

        public override string ToString()
        {
            return $"Betalingsnummer: {BetalingsNr}, Bedrag: {Bedrag}, Datum: {Datum.ToShortDateString()}";
        }

        #endregion


    }
}
