﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUnidadeMedida
    {
        public ModeloUnidadeMedida()
        {
            this.UmedCod = 0;
            this.UmedNome = "";
        }
        public ModeloUnidadeMedida(int cod, string nome)
        {
            this.UmedCod = cod;
            this.UmedNome = nome;
        }

        private int umed_cod;
        public int UmedCod
        {
            get
            {
                return this.umed_cod;
            }
            set
            {
                this.umed_cod = value;
            }
        }

        private string umed_nome;
        public string UmedNome
        {
            get
            {
                return this.umed_nome;
            }
            set
            {
                this.umed_nome = value;
            }
        }
    }
}
