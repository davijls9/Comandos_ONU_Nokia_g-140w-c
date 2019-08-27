using System;
using System.IO;
using System.Collections.Generic;

namespace Fazer_Codigo_CFGCLI
{
    class Program
    {

        static void Main(string[] args)
        {
            Modulo prog = new Modulo();
            string textofinal = "";

            Console.WriteLine(prog.getValueArray());
            for (int i = 0; i < prog.getValueArray(); i++) // colocando os comandos corretamente
            {
                prog.Identificao(i);
                if (i > 233) // Codigo dá erro apartir daqui, ele não consegue reconhecer totalmente
                {
                    if (i < prog.getValueArray())
                    {
                        prog.setLista(i);
                    }
                }
            }
            for (int i = 0; i < prog.getValueArray(); i++) // Adicionando valores
            {
                if (i < prog.getValueArray())
                {
                    prog.setListaValue(i);
                }
            }
            textofinal = prog.getLista();
            File.WriteAllText("Arquivo_Com_Comandos.txt", textofinal); //Gerando arquivo com a informação
            Console.WriteLine(textofinal);
            Console.ReadKey();
        }
    }
}
