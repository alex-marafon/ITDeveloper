using Cooperchip.ITDeveloper.Mvc.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.ViewComponents.EstadoPaciente
{
    [ViewComponent(Name = "EstadoGrave")]
    public class EstadoGraveViewComponents : ViewComponent
    {
        public EstadoGraveViewComponents()
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
                Titulo = "Paciente  Grave",
                Parcial = (int)totalEstado,
                Percentual = prct,
                ClassContainer = "panel panel-success tile panelClose panelRefresh",
                IconeLg = "l-banknote",
                IconSmal = "fa fa-arrow-circle-o-down s20 mr5 pull-left",
                Progress = progress

            };
            return View(model);
        }
    }
}
