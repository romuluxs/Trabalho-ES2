using LoginBancoTeste.DAL;
using LoginBancoTeste.Models;
using LoginBancoTeste.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LoginBancoTeste.Controllers
{
    public class AutenticadorController : Controller
    {
        private BancoContext db = new BancoContext();

        // GET: Autenticador
        public ActionResult Formulario()
        {
            return View();
        }

        // Método para realizar o login do cliente no sistema
        public ActionResult Entrar(LoginViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                Cliente cliente = this.db.Clientes.Where(s => usuario.Username == s.Username).SingleOrDefault();

                if (cliente == null)
                {
                    ViewBag.Mensagem = "Cliente inexistente ou não cadastrado!";
                    return View("Formulario");
                }

                if (usuario.Username != null && usuario.Password != null &&
                    usuario.Username.Equals(cliente.Username) && usuario.Password.Equals(cliente.Password))
                {
                    FormsAuthentication.SetAuthCookie(cliente.Username, false);
                    return RedirectToAction("Index", "Transacoes", new { id = cliente.Id });
                }
                else
                {
                    ViewBag.Mensagem = "Verifique se os dados estão corretos";
                    return View("Formulario", usuario);
                }
            }

            return View(usuario);
        }

        // método que faz logout
        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Formulario");
        }

    }
}