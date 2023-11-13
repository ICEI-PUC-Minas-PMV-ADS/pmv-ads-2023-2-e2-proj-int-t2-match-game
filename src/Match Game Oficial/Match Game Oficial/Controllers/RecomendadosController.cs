
using Match_Game_Oficial.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Match_Game_Oficial.Controllers
{
    public class RecomendadosController : Controller
    {
        // Dicionários para mapear valores dos enums para os valores desejados
        private static readonly Dictionary<Form_Gen, string> GeneroMapping = new Dictionary<Form_Gen, string>
        {
            { Form_Gen.Ação, "1" },
            { Form_Gen.Indie, "2" },
            { Form_Gen.Aventura, "3" },
            { Form_Gen.Rpg, "4" },
            { Form_Gen.Estratégia, "5" },
            { Form_Gen.Shooter, "6" },
            { Form_Gen.Casual, "7" },
            { Form_Gen.Simulação, "8" },
            { Form_Gen.Puzzle, "9" },
            { Form_Gen.Arcade, "10" },
            { Form_Gen.Plataformer, "11" },
            { Form_Gen.Multiplayer, "12" },
            { Form_Gen.Race, "13" },
            { Form_Gen.Sports, "14" },
            { Form_Gen.Fight, "15" },
            { Form_Gen.Family, "16" },
            { Form_Gen.BoardGames, "17" },
            { Form_Gen.Educational, "18" },
            { Form_Gen.Card, "19" }
        };

        private static readonly Dictionary<Form_Plat, string> PlataformaMapping = new Dictionary<Form_Plat, string>
        {
            { Form_Plat.IOS, "4" },
            { Form_Plat.Playstations, "2" },
            { Form_Plat.Xbox, "3" },
            { Form_Plat.Computador, "1" },
            { Form_Plat.Android, "8" },
            { Form_Plat.Linux, "6" },
            { Form_Plat.Nintendo, "7" },
            { Form_Plat.Atari, "9" },
            { Form_Plat.Comodore, "10" },
            { Form_Plat.Sega, "11" },
            { Form_Plat.Web, "14" }
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Recomendado model)
        {
            if (ModelState.IsValid)
            {
                // Obter os valores necessários do modelo
                var anoInicial = model.AnoInicial;
                var anoFinal = model.AnoFinal;
                var plataforma = model.Plataforma;
                var genero = model.Genero;

                // Verificar se os valores estão nos dicionários
                if (GeneroMapping.TryGetValue(genero, out var generoMapeado) && PlataformaMapping.TryGetValue(plataforma, out var plataformaMapeada))
                {
                    // Construir a URL da API com base nos valores do modelo
                    var apiUrl = $"https://api.rawg.io/api/games?key=69f74f8a6cde46529c5d0923786cdab7&parents_platforms={plataformaMapeada}&genres={generoMapeado}&dates={anoInicial}-01-01,{anoFinal}-06-01";

                    // Executar um script JavaScript para salvar no localStorage
                    ViewData["Script"] = $"<script>localStorage.setItem('apiUrl', '{apiUrl}'); alert('Seus dados foram salvos no localStorage e os dados foram enviados!'); window.location.href='/JogosRecomendados';</script>";

                    // Retornar para a mesma view
                    return View(model);
                }
            }

            // Se o modelo não for válido, retorne para a view com os erros de validação.
            return View(model);
        }
    }
}
