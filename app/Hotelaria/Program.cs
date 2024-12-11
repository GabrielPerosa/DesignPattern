using Hotelaria.Models;

Quarto quartoVistaPraia = QuartoFactory.CriarQuarto(TipoQuarto.Luxo);
quartoVistaPraia = new QuartoComVistaParaPraia(quartoVistaPraia);
quartoVistaPraia = new QuartoComCafe(quartoVistaPraia);

Console.WriteLine(quartoVistaPraia.Descricao());