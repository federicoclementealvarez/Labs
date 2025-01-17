﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Jugada
    {
        private Boolean _adivino;
        private int _intentos;
        private int _numero;

        public Jugada(int maxNumero)
        {
            Random r = new Random();
            _numero = (r.Next(maxNumero)+1);
            _adivino = false;
            _intentos= 0;
        }

        public Boolean Adivino
        {
            get => _adivino;
            set
            {
                _adivino = value;
            }
        }

        public int Intentos
        {
            get => _intentos;
            set
            {
                _intentos = value;
            }
        }

        public int Numero
        {
            get => _numero;
            set
            {
                _numero = value;
            }
        }

        public void comparar(int numIngresado)
        {
            _intentos++;
            if (numIngresado == _numero) _adivino = true;
        }
    }
}
