using Models;
using Services;

namespace Controllers
{
    public class ONGController
    {
        public Pessoa AdicionarPessoa()
        {
            return new ONGServices().InserirPessoaBanco();
        }

        public Pessoa SelecionarPessoa()
        {
            return new ONGServices().SelecionarPessoasBanco();
        }

        public Pessoa AtualizarPessoa()
        {
            return new ONGServices().AtualizarPessoaBanco();
        }

        public Animal AdicionarAnimal()
        {
            return new ONGServices().InserirAnimalBanco();
        }

        public Animal SelecionarAnimal()
        {
            return new ONGServices().SelecionarAnimaisBanco();
        }

        public Animal AtualizarAnimal()
        {
            return new ONGServices().AtualizarAnimalBanco();
        }

        public Pessoa Adotar()
        {
            return new ONGServices().AdotarAnimal();
        }

        public Animal SelecionarAdotados()
        {
            return new ONGServices().SelecionarAnimaisAdotadosBanco();
        }

        public Animal SelecionarDisponiveis()
        {
            return new ONGServices().SelecionarAnimaisDisponiveisBanco();
        }
    }
}
