
namespace Nydus_Suporte.Cadastro.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.UsuariosRow))]
    public class UsuariosController : Controller
    {
        [Route("Cadastro/Usuarios")]
        public ActionResult Index()
        {
            return View("~/Modules/Cadastro/Usuarios/UsuariosIndex.cshtml");
        }
    }
}