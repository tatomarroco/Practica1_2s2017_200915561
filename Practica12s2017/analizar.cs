using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica12s2017;

namespace Practica12s2017{
    class analizar{

        lstsem ls = new lstsem();

        //String cadena = "";

        public int estado;
        public char caracter;

        public String LexAux;

        //public int linea, NoTo;
        //public int columna, Entero;
        public int controlList = 0;

        public String resultado = "";

        //ListaSem listas = new ListaSem();

        public analizar(){}

        public lstsem getListaSem()
        {
            return this.ls;
        }

        public void setListaSem(lstsem l)
        {
            this.ls = l;
        }

        public void escanear(String cadena){
            estado = 0;
            cadena = cadena + "#";

            for(int z=0;z<=cadena.Length-1;z++){
                caracter = cadena[z];

                switch (estado){
                    //ESTADO 0
                    case 0:
                        if(caracter=='{' || caracter=='}' || caracter=='"' || caracter==','){
                            estado = 0;
                        }
                        else if(caracter==':'){
                        }
                        else if(caracter=='a' || caracter=='b' || caracter=='c'|| caracter=='d'|| caracter=='e'|| caracter=='f'|| caracter=='g'|| caracter=='h'|| caracter=='i'|| caracter=='j'|| caracter=='k'|| caracter=='l'|| caracter=='m' || caracter=='n'|| caracter=='o'|| caracter=='p'|| caracter=='q'|| caracter=='r'|| caracter=='s'|| caracter=='t'|| caracter=='u'|| caracter=='v'|| caracter=='w'|| caracter=='x'|| caracter=='y' || caracter=='z'|| caracter=='A'|| caracter=='B'|| caracter=='C'|| caracter=='D'|| caracter=='E'|| caracter=='F'|| caracter=='G'|| caracter=='H'|| caracter=='I'|| caracter=='J'|| caracter=='K'|| caracter=='L'|| caracter=='M'|| caracter=='N'|| caracter=='O'|| caracter=='P'|| caracter=='Q'|| caracter=='R'|| caracter=='S'|| caracter=='T'|| caracter=='U'|| caracter=='V'|| caracter=='W'|| caracter=='X'|| caracter=='Y'|| caracter=='Z'){
                           estado=1;
                           LexAux = caracter.ToString();
                       }
                       else if (caracter == '1' || caracter == '2' || caracter == '3' || caracter == '4' || caracter == '5' || caracter == '6' || caracter == '7' || caracter == '8' || caracter == '9' || caracter == '0'){
                           estado=2;
                           LexAux = caracter.ToString();
                       }
                       break;
                    //ESTADO 1
                    case 1:
                        if(caracter=='a' || caracter=='b' || caracter=='c'|| caracter=='d'|| caracter=='e'|| caracter=='f'|| caracter=='g'|| caracter=='h'|| caracter=='i'|| caracter=='j'|| caracter=='k'|| caracter=='l'|| caracter=='m' || caracter=='n'|| caracter=='o'|| caracter=='p'|| caracter=='q'|| caracter=='r'|| caracter=='s'|| caracter=='t'|| caracter=='u'|| caracter=='v'|| caracter=='w'|| caracter=='x'|| caracter=='y' || caracter=='z'|| caracter=='A'|| caracter=='B'|| caracter=='C'|| caracter=='D'|| caracter=='E'|| caracter=='F'|| caracter=='G'|| caracter=='H'|| caracter=='I'|| caracter=='J'|| caracter=='K'|| caracter=='L'|| caracter=='M'|| caracter=='N'|| caracter=='O'|| caracter=='P'|| caracter=='Q'|| caracter=='R'|| caracter=='S'|| caracter=='T'|| caracter=='U'|| caracter=='V'|| caracter=='W'|| caracter=='X'|| caracter=='Y'|| caracter=='Z'){
                           estado=1;
                           LexAux += caracter.ToString();
                        }else if(caracter == '"'){
                            ls.Add("Identificador", LexAux);
                            estado = 0;
                            LexAux = "";
                        }
                       break;
                    case 2:
                        if (caracter == '1' || caracter == '2' || caracter == '3' || caracter == '4' || caracter == '5' || caracter == '6' || caracter == '7' || caracter == '8' || caracter == '9' || caracter == '0'){
                               estado=2;
                               LexAux += caracter.ToString();
                        }
                        else if (caracter == '.'){
                            estado = 3;
                            LexAux += caracter.ToString();
                        }
                        /*else if (caracter == '"')
                        {
                            //ls.Add("Carnet", LexAux);
                            estado = 0;
                            LexAux = "";
                        }*/
                        //FIN DE CADENA
                        if (caracter == '#')
                        {
                            estado = 0;
                            LexAux = "";
                            break;
                        }
                        break;
                    case 3:
                        if (caracter == '1' || caracter == '2' || caracter == '3' || caracter == '4' || caracter == '5' || caracter == '6' || caracter == '7' || caracter == '8' || caracter == '9' || caracter == '0')
                        {
                            estado = 3;
                            LexAux += caracter.ToString();
                        }
                        else if (caracter == '.')
                        {
                            estado = 2;
                            LexAux += caracter.ToString();
                        }
                        else if (caracter == '"')
                        {
                            estado = 4;
                        }
                        break;
                    case 4:
                        ls.Add("DirIp", LexAux);
                        estado = 0;
                        LexAux = "";
                        break;

                }

            }

            setListaSem(ls);
        }

        
    }
}
