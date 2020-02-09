using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
    public class Airport
    {
        private string nazwa;
        private string miejscowosc;
        private string wojewodztwo;
        private string iata;
        private string dlugosc;
        private string ns;
        private string ew;

        //public Airport(string nazwa, string miejscowosc, string wojewodztwo, string iata, string dlugosc, string ns, string ew)
        //{
        //    this.Nazwa = nazwa;
        //    this.Miejscowosc = miejscowosc;
        //    this.Wojewodztwo = wojewodztwo;
        //    this.Iata = iata;
        //    this.Dlugosc = dlugosc;
        //    this.Ns = ns;
        //    this.Ew = ew;
        //}

        public string Nazwa{ get => nazwa; set => nazwa = value; }
        public string Miejscowosc { get => miejscowosc; set => miejscowosc = value; }
        public string Wojewodztwo { get => wojewodztwo; set => wojewodztwo = value; }
        public string Iata { get => iata; set => iata = value; }
        public string Dlugosc { get => dlugosc; set => dlugosc = value; }
        public string Ns { get => ns; set => ns = value; }
        public string Ew { get => ew; set => ew = value; }
    }
}
