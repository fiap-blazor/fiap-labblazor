namespace FIAP.LabBlazor.Components.InjecaoDependencia;

public interface IUsuarioServico
{
    Task<IReadOnlyList<Usuario>> ObterUsuariosAsync();
}    

public class UsuarioServico : IUsuarioServico
{
    public Task<IReadOnlyList<Usuario>> ObterUsuariosAsync()
    {
        IReadOnlyList<Usuario> produtos =
        [
            new() { Id = 1, Nome = "Fulano de Tal", EstaAtivo = true  },
            new() { Id = 2, Nome = "Cicrano de Tal", EstaAtivo = false },
            new() { Id = 3, Nome = "Beltrano de Tal", EstaAtivo = true }
        ];
        return Task.FromResult(produtos);
    }
}
