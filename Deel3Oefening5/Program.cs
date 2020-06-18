using System;
using System.Collections.Generic;
using System.Linq;

namespace Deel3Oefening5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //HoogsteBoetes();
            OudsteSpeler();
        }

        private static void OudsteSpeler()
        {
            var result = from speler in GetSpelers() orderby speler.GeboorteDatum ascending select speler;
            Console.WriteLine(result.First());
        }

        private static void HoogsteBoetes()
        {
            var result = from speler in GetSpelers()
                         where speler.Boetes.Count > 0
                         orderby speler.Naam ascending, speler.GeboorteDatum.Year descending, speler.Boetes.Count descending
                         select new { speler.Nummer, speler.Naam, Geboortedatum = speler.GeboorteDatum.ToShortDateString(), BoetesAantal = speler.Boetes.Count };
            result.ToList().ForEach(speler =>
            {
                Console.WriteLine($"Naam: {speler.Naam}, Geboortedatum: {speler.Geboortedatum} heeft {speler.BoetesAantal} boetes");

            });
        }

        private static List<Speler> GetSpelers()
        {
            List<Speler> spelers = new List<Speler>
            {
                new Speler{Nummer=2,Naam="Elfring",Voorletters="R",GeboorteDatum=new DateTime(1984,9,1), Geslacht='M',JaarToetreding=1975,Straat="Steden",HuisNr="43",Postcode="3575NH", Plaats="Den Haag",Telefoon="070-476537",BondsNr="2411", Boetes = new List<Boete>{}},
                new Speler{Nummer=6,Naam="Permentier",Voorletters="R",GeboorteDatum=new DateTime(1964,6,25), Geslacht='M',JaarToetreding=1977,Straat="Hazensteinln",HuisNr="80",Postcode="1234KK", Plaats="Den Haag",Telefoon="070-476537",BondsNr="8467", Boetes = new List<Boete>{new Boete{BetalingsNr=1,SpelersNr=6,Datum=new DateTime(1980,12,08),Bedrag=100M}}},
                new Speler{Nummer=7,Naam="Wijers",Voorletters="GWS",GeboorteDatum=new DateTime(1963,5,11), Geslacht='M',JaarToetreding=1981,Straat="Erasmusweg",HuisNr="39",Postcode="9758VB", Plaats="Den Haag",Telefoon="070-347689",BondsNr="", Boetes = new List<Boete>{}},
                new Speler{Nummer=8,Naam="Niewenburg",Voorletters="B",GeboorteDatum=new DateTime(1962,7,8), Geslacht='V',JaarToetreding=1980,Straat="Spoorlaan",HuisNr="4",Postcode="6584WO", Plaats="Rijswijk",Telefoon="070-458458",BondsNr="2983", Boetes = new List<Boete>{new Boete{BetalingsNr=6,SpelersNr=8,Datum=new DateTime(1980,12,8),Bedrag=25M}}},
                new Speler{Nummer=27,Naam="Cools",Voorletters="DD",GeboorteDatum=new DateTime(1964,12,28), Geslacht='V',JaarToetreding=1983,Straat="Liespad",HuisNr="804",Postcode="8457DK", Plaats="Zoetermeer",Telefoon="079-234857",BondsNr="", Boetes = new List<Boete>{new Boete{BetalingsNr=3,SpelersNr=27,Datum=new DateTime(1983,9,10),Bedrag=100M},new Boete{BetalingsNr=8,SpelersNr=27,Datum=new DateTime(1984,11,12),Bedrag=75M}}},
                new Speler{Nummer=28,Naam="Cools",Voorletters="C",GeboorteDatum=new DateTime(1963,06,22), Geslacht='V',JaarToetreding=1983,Straat="Oudegracht",HuisNr="10",Postcode="1294QK", Plaats="Leiden",Telefoon="010-659599",BondsNr="", Boetes = new List<Boete>{}},
                new Speler{Nummer=39,Naam="Bischoff",Voorletters="B",GeboorteDatum=new DateTime(1965,10,29), Geslacht='M',JaarToetreding=1980,Straat="Ericaplein",HuisNr="78",Postcode="9629CD", Plaats="Den Haag",Telefoon="070-393435",BondsNr="", Boetes = new List<Boete>{}},
                new Speler{Nummer=44,Naam="Bakker, de",Voorletters="E",GeboorteDatum=new DateTime(1963,1,9), Geslacht='M',JaarToetreding=1980,Straat="Lawaaistraat",HuisNr="23",Postcode="4444LJ", Plaats="Rijswijk",Telefoon="070-368753",BondsNr="1124", Boetes = new List<Boete>{new Boete{BetalingsNr=2,SpelersNr=44,Datum=new DateTime(1981,5,5),Bedrag=75M},new Boete{BetalingsNr=5,SpelersNr=44,Datum=new DateTime(1980,12,8),Bedrag=25M},new Boete{BetalingsNr=7,SpelersNr=44,Datum=new DateTime(1982,12,30),Bedrag=30M}}},
                new Speler{Nummer=57,Naam="Bohemen, van",Voorletters="M",GeboorteDatum=new DateTime(1971,8,17), Geslacht='M',JaarToetreding=1985,Straat="Erasmusweg",HuisNr="16",Postcode="4377CB", Plaats="Den Haag",Telefoon="070-473458",BondsNr="6409", Boetes = new List<Boete>{}},
                new Speler{Nummer=83,Naam="Hofland",Voorletters="PK",GeboorteDatum=new DateTime(1956,11,11), Geslacht='M',JaarToetreding=1982,Straat="Mariakade",HuisNr="16a",Postcode="1812UP", Plaats="Den Haag",Telefoon="070-353548",BondsNr="1608", Boetes = new List<Boete>{}},
                new Speler{Nummer=95,Naam="Meuleman",Voorletters="P",GeboorteDatum=new DateTime(1963,5,14), Geslacht='M',JaarToetreding=1972,Straat="Hoofdweg",HuisNr="33a",Postcode="5746OP", Plaats="Voorburg",Telefoon="070-867564",BondsNr="", Boetes = new List<Boete>{}},
                new Speler{Nummer=100,Naam="Permentier",Voorletters="P",GeboorteDatum=new DateTime(1963,2,28), Geslacht='M',JaarToetreding=1979,Straat="Hazensteinln",HuisNr="80",Postcode="6494SG", Plaats="Den Haag",Telefoon="070-494593",BondsNr="6524", Boetes = new List<Boete>{}},
                new Speler{Nummer=104,Naam="Moerman",Voorletters="D",GeboorteDatum=new DateTime(1970,5,10), Geslacht='V',JaarToetreding=1984,Straat="Stoutlaan",HuisNr="65",Postcode="9437AO", Plaats="Zoetermeer",Telefoon="079-987571",BondsNr="7060", Boetes = new List<Boete>{new Boete{BetalingsNr=4,SpelersNr=104,Datum=new DateTime(1984,12,8),Bedrag=50M}}},
                new Speler{Nummer=112,Naam="Baalen, van",Voorletters="IP",GeboorteDatum=new DateTime(1963,10,1), Geslacht='V',JaarToetreding=1984,Straat="Vosseweg",HuisNr="8",Postcode="6392LK", Plaats="Rotterdam",Telefoon="010-548745",BondsNr="1319", Boetes = new List<Boete>{}}
            };

            return spelers;
        }
    }
}
