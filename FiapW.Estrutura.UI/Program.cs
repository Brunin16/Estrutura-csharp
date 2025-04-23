using FiapW.Estrutura.Controller;

UsuarioController usuario = new UsuarioController();

if(usuario.validarUsuario("luiz_martins", "senha654"))
{
    Console.WriteLine("Usuario valido");
}
else 
{ 
    Console.WriteLine("Usuário ou senha inválidos");
}