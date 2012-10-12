using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Controllers
{
    /*
     * El controlador es el punto de entrada de los requests provenientes del cliente.
     * Se encarga de administrar toda la lógica del programa y delegar al modelo la interacción de la base
     * de datos.
     * 
     * Una vez terminado, encarga a la vista el despliegue del template final que será lo que el cliente
     * verá en el response.
     * 
     * Para definir un nuevo controlador crear una nueva clase en la carpeta "Controllers". Esta debe
     * SIEMPRE terminar con el sufijo Controller.
     * 
     * Los controladores se dividen en un conjunto de actions más métodos auxiliares. Cada action
     * es el encargado de manejar una ruta distinta. La idea es que cada controlador englobe dentro
     * de sus distintos actions tareas relacionadas. Tareas muy distintas las una de las otra se pueden
     * colocar en otros controladores. Nota: se puede hacer todo en un mismo controlador, pero no
     * es recomendable (sería análogo a hacer todo en el main !!!).
     * 
     * Un action debe devolver un ActionResult.
     * 
     * Para acceder desde el browser a su action deben ingresar la ruta:
     * host/controlador/action
     * 
     * En el caso del action index, solamente es:
     * host/controlador
     * 
     * Pueden acceder a variables del query de la URL definiendo parámetros en el action. El nombre
     * del parámetro debe ser el mismo que el nombre del key del valor del query. Si quieren que 
     * un parámetro sea opcional definal un parámetro con valor por default.
     * 
     * Variables que quieran calcular en el action para luego pasárselas a la vista se traspasan mediante
     * la variable dinámica ViewBag. Como vimos es posible hacer cómputo en la vista también mediante
     * Razor pero esto es FUERTEMENTE NO RECOMENDADO! En general, todo cómputo debiese hacerse en el controlador
     * y delegar a la vista solo el despliegue de la información en variables originadas del controlador.
     * 
     * Se recomienda fuertemente estudiar el uso de la palabra reservada "dynamic" en C# para entender bien
     * cómo es que ViewBag funciona.
     * 
     * Al final del controlador debiesen devolver la vista asociada.
     * 
     * Para un controlador dado, su vista por default se encuentra en la carpeta Views/Controlador/Action
     * 
     * 
     */


    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            List<string> list = new List<string>();
            list.Add("elemento 1");
            list.Add("elemento 2");
            list.Add("elemento 3");
            list.Add("elemento 4");
            list.Add("elemento 5");

            ViewBag.test = list;

            return View();
        }

        public ActionResult Prueba()
        {
            return View();
        }

    }
}
