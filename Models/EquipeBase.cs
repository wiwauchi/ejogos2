using System.IO;

namespace EJOGOS2.Models
{
    public class EquipeBase
    {
        public void CriarPastaOuArquivo(string caminho)
        {
            // nomedapasta/nomedoarquivo.csv

            string pasta = caminho.Split('/')[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
                
            }

            if(!File.Exists(pasta))
            {
                File.Create(caminho);
            }
            


        }

    }
}
