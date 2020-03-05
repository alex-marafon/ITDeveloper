using Cooperchip.ITDeveloper.Mvc.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.ViewComponents.EstadoPaciente
{
    [ViewComponent(Name ="EstadoCritico")]
    public class EstadoCriticoViewComponents : ViewComponent
    {
        public EstadoCriticoViewComponents()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var totalGeral = Util.TolReg();
            decimal totalEstado = Util.GetNumeRegEstado();

            decimal progress = totalEstado * 100 / totalGeral;
            var prct = progress.ToString(format: "F1");

            var model = new ContadorEstadoPaciente()
            {
                Titulo = "Paciente em Critico",
                Parcial = (int)totalEstado,
                Percentual = prct,
                ClassContainer = "panel panel-Info tile panelClose panelRefresh",
                IconeLg = "l-basic-geolocatize-05",
                IconSmal = "fa fa-arrow-circle-o-up s20 mr5 pull-left",
                Progress = progress

            };
            return View(model);
        }
    }
}
