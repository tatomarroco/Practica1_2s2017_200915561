using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica12s2017
{
    class NodoSem{
        public String tok;
        public String valor;
        //public int num;

        public NodoSem Ant;
        public NodoSem Sig;

        public NodoSem(String tok, String valor){
            this.tok = tok;
            this.valor = valor;
            //this.num = num;
            this.Ant = null;
            this.Sig = null;
        }

        /**
     * Establece a null el enlace Siguiente del Nodo 
     */
        public void RomperEnlaceSig(){
            this.Sig = null;
        }

        /**
         * Establece a null el enlace Anterior del Nodo 
         */
        public void RomperEnlaceAnt(){
            this.Ant = null;
        }

        /**
         * @return the tok
         */
        public String gettok(){
            return tok;
        }

        /**
         * @param Tok the Token to set
         */
        public void setLetra(String tok){
            this.tok = tok;
        }


        public String getvalor()
        {
            return valor;
        }

        /**
         * @param Tok the Token to set
         */
        public void setValor(String valor)
        {
            this.valor = valor;
        }


    }
}
