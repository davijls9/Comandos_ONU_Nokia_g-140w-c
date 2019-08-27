# Obter comandos ONU Nokia g-140w-c apartir de um script.

O codigo ajudará a obter comandos para a ONU da Nokia, partir do XML dela.
OBS: O XML é obtido apartir do acesso de um usuario, e entrando normalmente no ENDEREÇOIP/dumpdatamodel.cgi.
Apartir disso você conseguirar obter o codigo XML. 

# O que tem dentro de cada .cs

Dentro do Program.cs, tem a parte para rodar o codigo modularizado. ele será monstrado em console (Escolhido por conta de desempenho), com isso obterar na tela, os comandos em um arquivo no debug dele.
Dentro do arquivo Modulos.cs, será encontrado uma parte para leitura de arquivo. Esse arquivo de leitura, será o xml de onde terar que editar o diretorio para que possa conseguir ler eles. Após a leiturar do arquivo ele será rodado, para que seja varrido, fazendo que após isso, gerer outro arquivo. 


# OBSERVAÇÃO

Certo valores devem ser analisado. Exemplo: Caso a quantidade de valores dentro da lista seja diferente, deve atualizar os valores de dentro dos metodos.

