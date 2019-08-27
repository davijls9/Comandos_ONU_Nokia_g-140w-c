using System;
using System.IO;
using System.Collections.Generic;

namespace Fazer_Codigo_CFGCLI
{
    class Modulo
    {
        //Armazenando a informação de um arquivo em uma array
        string[] array = File.ReadAllLines(@"D:\Cursos\Curso Programação orientada a objetos C#\Projetos\source\Fazer Codigo CFGCLI\Fazer Codigo CFGCLI\bin\Debug\netcoreapp2.1\dumpdatamodel.txt");
        string Comands = "cfgcli -f -s ";
        int identacao = 0;
        List<string> lista = new List<string>(); // Criando uma Lista

        public int getValueArray() { return array.Length; } // Retornando valores do array

        private void Linha(string linha) // Adicionando uma ao Comands o comando em especifico
        {
            string[] aux = linha.Split(" ");
            string[] aux2 = aux[0].Split("<");
            string comando = this.Comands + aux2[1];
            this.Comands = comando;
            identacao++;
        }
        private void AdicionarIdentação(int posicao) // Dá identação a linha
        {
            Linha(array[posicao]);
        }
        private void RetirarIdentacao(string linha) // Autentificando a retirada de valores
        {
            string[] retirar = this.Comands.Split(".");
            string[] aux = linha.Split(" ");
            string[] aux2 = aux[0].Split("<");
            int contPont = 0;

            for (int i = 0; i < retirar.Length; i++)
            {
                if (retirar[i] == "1")
                {
                    contPont = 2;
                }
                if (retirar[i] == "2")
                {
                    contPont = 2;
                }
                if (retirar[i] == "3")
                {
                    contPont = 2;
                }
                if (retirar[i] == "4")
                {
                    contPont = 2;
                }
                if (retirar[i] == "5")
                {
                    contPont = 2;
                }
                if (retirar[i] == "6")
                {
                    contPont = 2;
                }
                if (retirar[i] == "7")
                {
                    contPont = 2;
                }
                if (retirar[i] == "8")
                {
                    contPont = 2;
                }
                if (retirar[i] == "9")
                {
                    contPont = 2;
                }
                if (retirar[i] == "10")
                {
                    contPont = 2;
                }
                if (retirar[i] == "11")
                {
                    contPont = 2;
                }
                if (retirar[i] == "12")
                {
                    contPont = 2;
                }
                if (retirar[i] == "13")
                {
                    contPont = 2;
                }
                if (retirar[i] == "14")
                {
                    contPont = 2;
                }
                if (retirar[i] == "14")
                {
                    contPont = 2;
                }
                if (retirar[i] == "14")
                {
                    contPont = 2;
                }
                if (retirar[i] == "15")
                {
                    contPont = 2;
                }
                if (retirar[i] == "16")
                {
                    contPont = 2;
                }
                if (retirar[i] == "17")
                {
                    contPont = 2;
                }
                if (retirar[i] == "18")
                {
                    contPont = 2;
                }
                if (retirar[i] == "19")
                {
                    contPont = 2;
                }
                if (retirar[i] == "20")
                {
                    contPont = 2;
                }
                if (retirar[i] == "21")
                {
                    contPont = 2;
                }
                if (retirar[i] == "22")
                {
                    contPont = 2;
                }
                if (retirar[i] == "23")
                {
                    contPont = 2;
                }
                if (retirar[i] == "24")
                {
                    contPont = 2;
                }
                if (retirar[i] == "25")
                {
                    contPont = 2;
                }
                if (retirar[i] == "26")
                {
                    contPont = 2;
                }
                if (retirar[i] == "27")
                {
                    contPont = 2;
                }
                if (retirar[i] == "28")
                {
                    contPont = 2;
                }
                if (retirar[i] == "29")
                {
                    contPont = 2;
                }
                if (retirar[i] == "30")
                {
                    contPont = 2;
                }
                if (retirar[i] == "31")
                {
                    contPont = 2;
                }
                if (retirar[i] == "32")
                {
                    contPont = 2;
                }
                if (retirar[i] == "33")
                {
                    contPont = 2;
                }
                if (retirar[i] == "34")
                {
                    contPont = 2;
                }
                if (retirar[i] == "35")
                {
                    contPont = 2;
                }
                if (retirar[i] == "36")
                {
                    contPont = 2;
                }
                if (retirar[i] == "37")
                {
                    contPont = 2;
                }
                if (retirar[i] == "38")
                {
                    contPont = 2;
                }
                if (retirar[i] == "39")
                {
                    contPont = 2;
                }
                if (retirar[i] == "40")
                {
                    contPont = 2;
                }
                if (retirar[i] == "41")
                {
                    contPont = 2;
                }
                if (retirar[i] == "42")
                {
                    contPont = 2;
                }
                if (retirar[i] == "43")
                {
                    contPont = 2;
                }
                if (retirar[i] == "44")
                {
                    contPont = 2;
                }
                if (retirar[i] == "45")
                {
                    contPont = 2;
                }
                if (retirar[i] == "46")
                {
                    contPont = 2;
                }
                if (retirar[i] == "47")
                {
                    contPont = 2;
                }
                if (retirar[i] == "48")
                {
                    contPont = 2;
                }
                if (retirar[i] == "49")
                {
                    contPont = 2;
                }
                if (retirar[i] == "50")
                {
                    contPont = 2;
                }

            } // valores para reconhecer caso tiver codigo.1., fazendo que ele seja retirado da forma correta

            Comands = "";
            for (int q = 0; q < retirar.Length; q++) // Retirando valores
            {
                if (q < retirar.Length - 1 && retirar[q] != "")
                {
                    this.Comands += retirar[q] + ".";
                }

                if (contPont > 1) // Caso o contPont esteja acima de 1, ele i
                {
                    Comands = "";
                    for (int i = 0; i < retirar.Length; i++)
                    {
                        if (i < retirar.Length - i - 1)
                        {
                            this.Comands += retirar[i] + ".";
                        }

                    }
                }

                if (retirar[q] == "") // REtirando caso o valor do vetor final seja null
                {
                    Comands = "";
                    for (int i = 0; i < retirar.Length; i++)
                    {
                        if (i < retirar.Length - 2)
                        {
                            this.Comands += retirar[i] + ".";
                        }

                    }
                }
            }
        }

        public void Identificao(int posicao) // Identificando quais situações deve ser tomadas
        {
            string switTeste = array[posicao].Substring(array[posicao].Length - 2, 2);
            switch (switTeste)
            {
                case "/>": // adicionar conteudo a linha
                    Linha(array[posicao]);
                    lista.Add(Comands);
                    RetirarIdentacao(array[posicao]);
                    break;
                case ".>": // Saber que a o final da identação
                    RetirarIdentacao(array[posicao]);
                    lista.Add(Comands);
                    break;
                case "\">": // Saber o começo da identação
                    Linha(array[posicao]);
                    identacao++;
                    lista.Add(Comands);
                    break;
                default:
                    break;
            }
        }

        public string getLista()// retornando os valores da lista
        {
            lista.Add("");
            string textofinal = "";
            foreach (String t in lista)
            {
                textofinal += t + "\n";
            }
            return textofinal;
        }

        public void setLista(int posicao) // Setando valores na lista
        {
            if (posicao < 6492)
            {
                lista[posicao] = "cfgcli -f -s " + lista[posicao];
            }
        }

        public void setListaValue(int posicao) // editando parte dos valores para a lista todas atualizar
        {
            if (posicao < 6492)
            {
                string[] aux = array[posicao].Split(" ");

                for (int i = 0; i < aux.Length - 1; i++)
                {
                    try // No primeiro valor dá erro.
                    {
                        if (aux[i].Substring(0, 2) == "v=")
                        {
                            string[] aux2 = aux[i].Split("=");
                            lista[posicao] = lista[posicao] + " " + aux2[1];
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
    }
}
