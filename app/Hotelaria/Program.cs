using Hotelaria.Models;

Gerente gerente = Gerente.ObterInstancia();
Quarto quarto1 = QuartoFactory.CriarQuarto(TipoQuarto.Luxo);
Quarto quarto2 = QuartoFactory.CriarQuarto(TipoQuarto.Economico);
Quarto quarto3 = QuartoFactory.CriarQuarto(TipoQuarto.Medio);

gerente.AdicionarReserva(quarto1, "Gabriel");
gerente.AdicionarReserva(quarto2, "Giovani");
gerente.AdicionarReserva(quarto3, "Familia Rodrigues");

gerente.RemoverReserva(quarto1, "Gabriel");

gerente.ListarReservas();