using System.Collections.Generic;
using System.IO;
using InstaDev_G1_DT.Interfaces;

namespace InstaDev_G1_DT.Models
{
    public class PageRegister:InstaDevBase, IPageRegister
    {
        public string Email { get; set; }
        public string CompleteName { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        private const string PATH = "Database/register.csv"; // criação da pasta Database que armazanerá os arquivos CSV

        public PageRegister(){ // método construtor para criar os arquivos CSV
            CreateFolderAndFile(PATH); // método puxado de dentro da classe "InstaDevBase"
        }
        
        public string PrepareLinesCSV(PageRegister prepareLines){ // aqui será preparado o modo como será armazenado automaticamente as linhas dentro do CSV
            return $"{prepareLines.Email};{prepareLines.CompleteName};{prepareLines.NickName};{prepareLines.Password}";
        }

        public void Create(PageRegister newRegister){ // criará um novo usuário cadastrado no CSV (ou seja, uma nova linha no CSV)
            string[] dataToLines = {PrepareLinesCSV(newRegister)}; // o dataToLines(string array) irá memorizar os dados que forem preenchidos no cadastro de acordo com o método PrepareLinesCSV(que vai preparar a forma das informações nas linhas do CSV)
            File.AppendAllLines(PATH, dataToLines); // o arquivo CSV(File) chama um método já presente da biblioteca do System.IO que tem a função de anexar as os dados preenchidos pelo usuário que estão memorizadas no dataToLines || dentro do método AppendAllLines tem o PATH, que é onde ele vai anexar esses novos dados de cadastro; e o dataToLines(dados para linhas), que são os dados memorizados que serão "lançados" para dentro do PATH
        }

        public List<PageRegister> ReadAllItems(){ // aqui será lido/interpretado todos os itens das linhas do CSV (Email, Nome Completo, NickName e Senha)
            List<PageRegister> registers = new List<PageRegister>(); // atributo da lista que poderá ser chamado no contexto
            string[] infoData = File.ReadAllLines(PATH); // infoData(dados de informação) é onde será consultado pelo File e com o seu método ReadAllLines(que já é presente da biblioteca System.IO) para logo logo ser separado cada dado do CSV em seu respectivo "lugar"
            
            foreach(var item in infoData){ // o foreach ficará repetindo a função de "recolher" os dados que estão sendo consultados do infoData
                string[] data = item.Split(";"); // o "data" é onde será memorizado onde cada dado está (para conseguir chamar pelos números [0], [1], [2] etc) || o Split(";") está separando as informações, entendendo que a cada ";" é um novo tipo de dado
                
                PageRegister register = new PageRegister(); // aqui apenas foi a classe sendo instanciada para possibilitar puxar os atributos dela(Email, CompleteName, NickName e Password) e poder memorizar onde está cada dado nos números([1], [2], [3] etc)
                
                register.Email = data[0]; // aqui está começando a ser memorizado no "register" a posição que está cada dado
                register.CompleteName = data[1];
                register.NickName = data[2];
                register.Password = data[3];

                registers.Add(register); // aqui estamos adicionando o que foi instanciado para dentro da lista principal deste contexto
            }

            return registers; // aqui foi retornado a lista principal do contexto que contém todas as informações dos dados separadadas
        }

        public void Update(){} // SEM FUNCIONALIDADE NESTA PÁGINA

        public void Delete(){} // SEM FUNCIONALIDADE NESTA PÁGINA
    }
}