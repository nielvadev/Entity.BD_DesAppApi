
using DesAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Type = DesAppMVC.Models.Type;

namespace DesAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {

        public readonly WebApiContext _dbcontex;


        public ProductosController(WebApiContext _contex)
        {
            _dbcontex = _contex;
        }


        [HttpGet]
        [Route("ListaProd")]
        public IActionResult Listar()
        {

            List<Product> listProd = new List<Product>();

            try
            {
                listProd = _dbcontex.Products.ToList();
                return StatusCode(StatusCodes.Status200OK, new
                {
                    code = "OK",
                    message = "Consulta Exitosa",
                    Detail = listProd
                });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new
                {
                    code = "OK",
                    message = "Error al consultar",
                    Detail = ex.Message,
                    Source = ex.Source,
                    StackTrace = ex.StackTrace
                });

            }

        }

        [HttpGet]
        [Route("ListaTipos")]

        public IActionResult ListarTipos()
        {

            List<DesAppMVC.Models.Type> listTipos = new List<Type>();

            try
            {
                listTipos = _dbcontex.Type.ToList();
                return StatusCode(StatusCodes.Status200OK, new
                {
                    code = "OK",
                    message = "Consulta Exitosa",
                    Detail = listTipos
                });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new
                {
                    code = "OK",
                    message = "Error al consultar",
                    Detail = ex.Message,
                    Source = ex.Source,
                    StackTrace = ex.StackTrace
                });

            }

        }




    }
}
