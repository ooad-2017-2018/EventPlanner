﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    public class Administrator : Korisnik
    {
        public Administrator(string naziv, string sifra, string korisnickoime, string brojkartice) : base(naziv, sifra, korisnickoime, brojkartice)
        {

        }

        public void OtkaziRezervaciju(int brojrezervacije, Kontejnerska b)
        {
           for(int i = 0; i < b.ListaRezervacija.Count(); i++)
            {
                if (b.ListaRezervacija[i].BrojRezervacije == brojrezervacije) b.ListaRezervacija.Remove(b.ListaRezervacija[i]);
            }
        }
        public void DodajRezervaciju(Rezervacija rezervacija, Kontejnerska b)
        {
            b.ListaRezervacija.Add(rezervacija);
        }
        public void DodajKlijenta(Klijent klijent, Kontejnerska b)
        {
            b.ListaKlijenata.Add(klijent);
        }
        public void DodajSaradnika(Saradnik saradnik, Kontejnerska b)
        {
            b.ListaSaradnika.Add(saradnik);
        }
        public void ObrisiKlijenta(string korisnickoime, Kontejnerska b)
        {
            for(int i = 0; i < b.ListaKlijenata.Count(); i++)
            {
                if (b.ListaKlijenata[i].KorisnickoIme == korisnickoime) b.ListaKlijenata.Remove(b.ListaKlijenata[i]);
            }
        }
        public void ObrisiSaradnika(int id, Kontejnerska b)
        {
            for(int i = 0; i < b.ListaSaradnika.Count(); i++)
            {
                if (b.ListaSaradnika[i].Id == id) b.ListaSaradnika.Remove(b.ListaSaradnika[i]);
            }
        }

    }
}
