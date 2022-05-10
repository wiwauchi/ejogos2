using EJOGOS2.Models;
using System.Collections.Generic;

namespace EJOGOS2.Interface
{
    public interface IEquipe
    {
        // Contrato
        // representa os métodos que são obrigatórios em uma classe

        void Criar(Equipe novaequipe);

        List<Equipe> LerEquipes();

    }
}
