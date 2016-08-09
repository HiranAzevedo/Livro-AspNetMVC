using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;

namespace CadeMeuMedico.Repositorios
{
    public class RepositorioUsuario
    {
        public static bool AutenticarUsuario(string login, string senha)
        {
            var senhaCriptografada = FormsAuthentication.HashPasswordForStoringInConfigFile(senha, FormsAuthPasswordFormat.SHA1.ToString());
            try
            {
                using (EntidadesCadeMeuMedicoBD db = new EntidadesCadeMeuMedicoBD())
                {
                    var queryAutenticaUsuario = db.Usuarios.Where(x => x.Login == login && x.Senha == senha).SingleOrDefault();

                    if (queryAutenticaUsuario == null)
                    {
                        return false;
                    }
                    else
                    {
                        RepositorioCookies.RegistraCookieAutenticacao(queryAutenticaUsuario.IDUsuario);
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}