using ProjetoAPItarde.Model;

namespace ProjetoAPItarde.Repositorio
{
    public interface IFuncionarioRepositorio
    {
        void Add(Funcionario funcionario, IFormFile foto);

        List<Funcionario> GetAll();

        public Funcionario GetById(int id);

        void Update(Funcionario funcionario, IFormFile foto);

        void Delete(int id);
       
    }
}
