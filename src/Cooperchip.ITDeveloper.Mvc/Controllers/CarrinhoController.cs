using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            var produtos = new List<Produto>();
            for (int i = 1; i < 10; i++)
            {
                var n = i < 10 ? "0" + i : i + "";
                produtos.Add(new Produto
                {
                    Nome = "Prod-" + n,
                    Estoque = 3,
                    Validade = DateTime.Now,
                    Valor = 1.13M * i
                });
            }

            var model = new CarrinhoViewModels
            {
                Produtos = produtos,
                TotalCarrinho = produtos.Sum(p => p.Valor),
                //TotalCarrinho = 13.27M,
                Mensagem = "Obrigado Pela Compra"
                //Mensagem = "Ah!"

            };


            return View(model);
            //return RedirectToAction("Checkout", model);
        }

        //public IActionResult Checkout(CarrinhoViewModels model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        if(ModelState.ErrorCount > 0)
        //        {
        //            TempData["semerro"] = "OPS!";
        //            ModelState.AddModelError(errorMessage:"Errro modelo invalida", key: "Errrrouuuuu");
        //        }
        //    }
        //    else
        //    {
        //        TempData["semerro"] = "MODELO OK";
        //    }
        //    return View(model);
        //}
    }
}