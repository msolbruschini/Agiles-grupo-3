using System;
using CapaDatos;

namespace CapaNegocio2
{
    public class IniciarSesionUsuario
    {
        //instancio acceso a datos
        Usuario User = new Usuario();
        public bool LoginUser(string cuenta, string contra)
        {
            return User.Login(cuenta, contra);
        }

        /*public string recuperarPass(string userRequesting)
        {
            return User.recuperarPass(userRequesting);
        }*/


        //Attributos
        private int idUsu;
        private string cuenta;
        private string pass;
        private string email;
        private string tipo;
        

        //Constructores (se pone ambos constructores para poder utilizar con y sin parametros.
        public IniciarSesionUsuario()
        {

        }

        public IniciarSesionUsuario(int idU, string cuenta, string pass, string email, string tipo )
        {
            this.idUsu = idU;
            this.cuenta = cuenta;
            this.pass = pass;
            this.email = email;
            this.tipo = tipo;
            
        }

        


    }
}
