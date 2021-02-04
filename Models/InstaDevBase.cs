using System.Collections.Generic;
using System.IO;

namespace InstaDev_G1_DT.Models
{
    public class InstaDevBase
    {
        public void CreateFolderAndFile (string path){ // método geral que criará os arquivos CSV || o "path" será tipo um molde para conseguirmos chamar o PATH nas outras classes
            string folder = path.Split("/")[0]; // o folder está representando a nossa pasta Database
            
            // conferindo se existe alguma pasta(folder) chamada "Database" (se não existir, será criada):
            if(!Directory.Exists(folder)){ // esta exclamação(!) corresponde um sinal de negação, que não existe (ou seja, se não existe um diretório tal, será criado)
                Directory.CreateDirectory(folder);
            }

            // conferindo se existe algum arquivo CSV (se não existir, será criada):
            if(!File.Exists(path)){
                File.Create(path).Close();
            }
        }

        public List<string> ReadAllLinesCSV(string path){ // método em lista para fazer o código ler as linhas do CSV || o nome "ReadAllLinesCSV" é o nome do método, é o que vai ser puxado
            List<string> linesRead = new List<string>(); // o linesRead será o atributo que poderá ser puxado dentro deste contexto
            
            // o StreamReader vai ler (acho que posso dizer que ele vai conseguir "interpretar") as informações do CSV
            using(StreamReader file = new StreamReader(path)){ // o "using" vai abrir e fechar determinado tipo de arquivo e conexão ||o StreamReader é uma classe presente na biblioteca System.IO
                string line; // esse será o atributo que representará cada linha do CSV
                
                while((line = file.ReadLine()) !=null){ // se enquanto a linha(line) é lido e memorizado pelo file(StreamReader) não for nulo (ou seja, se o CSV for nulo, não acontecerá nada || porém, se existir linha, ou seja, ser diferente de nulo, a linha será memorizada pelo StreamReader)
                    linesRead.Add(line); // a cada linha que for lida e memorizada pelo StreamReader, essa linha memorizada será ARMAZENADA na lista de linhas lidas(linesRead)
                }
                
                return linesRead; // esse atributo linesRead será retornado toda vez que o método ReadAllLinesCSV for chamado
            }
        }

        public void ReWriteItemsCSV(string path, List<string> lines){ // método para reescrever/atualizar os "itens" dentro do CSV
            // o StreamWriter será responsável a escrever o texto dado de uma maneira específica(dentro de um "molde", tipo a localização com o [0], [1] etc) || o StreamWriter é uma classe da System.IO
            using(StreamWriter pencilEraser = new StreamWriter(path)){ // o "pencilEraser"(lápis borracha) é o atributo que foi instanciado da classe StreamWriter e que "apagará" a informação do item antigo e "escreverá" a nova informação no mesmo item apagado || o StreamWriter está "atuando" dentro da PATH, que é onde está o CSV || o "using" vai abrir e fechar o arquivo e fará a leitura (e nesse caso, a alteração)
                foreach(var item in lines){ // ocorrerá uma verificada nos itens do CSV, se caso em um dos itens ter alguma alteração no "item"...
                    pencilEraser.Write(item + "\n"); // o pencilEraser vai usar o seu método(que é um método do StreamWriter) Write(escrever) que vai alterar o item e vai pular uma linha com o "\n"
                }
            }
        }
    }
}