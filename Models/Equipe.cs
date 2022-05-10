using EJOGOS2.Interface;
using System.Collections.Generic;
using System.IO;

namespace EJOGOS2.Models
{

    //Herança 

    public class Equipe : EquipeBase, IEquipe
    {
        public int idEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        //variavel de dados
        private const string caminhobd = "Database/equipe.csv";
        private IEnumerable<string> equipe_texto;

        public Equipe()
        {
            // metodo da classe de herança EquipeBase
            CriarPastaOuArquivo(caminhobd);

        }


        // cirar uma função que vai receber o objeto Equipe e vai retornar formato csv
        private string Preparar(Equipe e)
        {
            // return e.idEquipe + ";" + e.Nome + ";" e.Imagem;

            return $"{e.idEquipe};{e.Nome};{e.Imagem}";
        }


        public void Criar(Equipe novaequipe)
        {
            string valor = Preparar(novaequipe);

            //array de strings = na posição 0 o retorno do "Preparar"
            string[] equipe_texto = { valor };

            //arquivo vamops adicionar nova linha
            File.AppendAllLines(caminhobd, equipe_texto);


        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> listaEquipes = new List<Equipe>();

            string[] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {
                // 1; nome da equipe; caminho da imagem
                string[] linhaEquipe = item.Split(";");

                Equipe equipeAtual = new Equipe();
                equipeAtual.idEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listaEquipes.Add(equipeAtual);

            }
            

            return listaEquipes;
        }





    }
}
