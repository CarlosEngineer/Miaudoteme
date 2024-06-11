using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miaudoteme.Domain.ValueObjects
{
    public static class Senha
    {

        public static string ValidaSenha(string senha)
        {
            ValidadeQuantidadeMinima(senha);

            return senha;
        }
        private static void ValidadeQuantidadeMinima(string senha)
        {
            if (senha == null) throw new ArgumentNullException("Senha n�o pode ser nula.");
            if (senha.Length < 6) throw new ArgumentNullException("A Quantidade m�nima � de 6 caracteres."); 
        }
    }
}