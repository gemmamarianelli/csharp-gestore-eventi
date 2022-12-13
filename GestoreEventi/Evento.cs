﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        //ATTRIBUTI

        private string titolo;
        private double data;
        private int capienzaMassima;
        private int postiPrenotati;

        public Evento(string titolo, double data, int capienzaMassima, int postiPrenotati)
        {
            this.titolo = titolo;
            this.data = data;
            this.capienzaMassima = 150;
            this.postiPrenotati = postiPrenotati;
        }

        //GETTERS
        public string GetTitolo() {
            return titolo;
        }
        public double GetData()
        {
            return data;
        }
        public int GetCapienzaMassima()
        {
            return capienzaMassima;
        }
        public int GetPostiPrenotati()
        {
            
            return postiPrenotati;
        }

        //SETTERS
        public string SetTitolo(string Titolo)
        {
            if (titolo == null|| titolo == "")
            {
               throw new Exception( "titolo evento non valido");
            }
            return titolo;
        }
        public double SetData()
        {
            if(data == null)
            {
                throw new Exception("data non disponibile");
            }
            DateTime corrente = DateTime.Now;
            return data;
           
        }

        
        
        public void PrenotaPosti()
        {
            if (postiPrenotati > 150)
            {
                throw new Exception("non puoi prenotare più di 150 posti");
            }
            if (postiPrenotati < 0)
            {
                throw new Exception("posto non disponibile");
            }
             
           
        }
       public void DisdiciPosti()
        {
            
        }
       
        
    }
}
