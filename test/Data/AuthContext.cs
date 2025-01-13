using test.Classes;

public class AuthContext
{
    private Usuarios usuarioAutenticado;

    public Usuarios UsuarioAutenticado
    {
        get { return usuarioAutenticado; }
        set { usuarioAutenticado = value; }
    }

    public bool IsAuthenticated
    {
        get { return usuarioAutenticado != null; }
    }

    public void Autenticar(Usuarios usuario)
    {
        usuarioAutenticado = usuario;
    }

    public void Logout()
    {
        usuarioAutenticado = null;
    }
}
