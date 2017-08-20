using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica12s2017
{
    class GestionArchivos{
        StreamReader entrada;
        //StreamWriter salida;
        //Stream archivo;

        analizar scan = new analizar();
        lstsem lis = new lstsem();

        public GestionArchivos(){
        }


        public String LeerArchivo(Stream Archivo)
        {
            String contenido = "";

            try{
                entrada = new StreamReader(Archivo);
                int ascii;
                while ((ascii = entrada.Read()) != -1){
                    char caracter = (char)ascii;
                    if (caracter == '\n' || caracter == '\r' || caracter == '\t')
                    {
                        
                        
                    }
                    else if (caracter == ' '){
                        //Si es espacio No hace nada
                    }
                    else{
                        contenido += caracter;
                    }
                }

            }
            catch (Exception e){
                Console.WriteLine("Error: "+e.Message);
            }
            Console.WriteLine(contenido);
            scan.escanear(contenido);
            lis.recorrer(scan.getListaSem());
            lis.Asigna(scan.getListaSem());
            return contenido;
        }


    }
}
