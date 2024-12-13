# Hotelaria - Sistema de Reservas 🏨
Este projeto implementa um sistema de reservas de quartos de hotel utilizando diversos padrões de design, como o Factory, Strategy, Decorator, Observer, e Singleton. O código foi projetado para gerenciar diferentes tipos de quartos, possibilitar a personalização das reservas com adicionais, calcular o preço e registrar todas as informações em um arquivo de log.

## Padrões de Design Utilizados 🛠️
### 1. Factory 🏗️
A classe QuartoFactory é responsável pela criação de objetos de diferentes tipos de quartos. Com isso, o código é capaz de criar quartos de tipos específicos como Básico, Médio e Luxo sem precisar saber como instanciá-los diretamente.

- Classe responsável: QuartoFactory
- Objetivo: Gerenciar a criação de quartos.
<br>

### 2. Strategy ⚙️
A estratégia de cálculo de preços é definida pela interface IEstrategiaDePreco, com diferentes implementações que calculam o preço com base no tipo de quarto.

- Interface: IEstrategiaDePreco
- Objetivo: Permitir a alteração do cálculo de preço dependendo do tipo de quarto.
<br>

### 3. Decorator 🎨
O padrão Decorator é utilizado para adicionar funcionalidades adicionais aos quartos, como vista para a praia ou café da manhã, sem alterar a estrutura das classes de quartos originais.

- Classe base: QuartoAdicionais
- Classes Decoradoras: QuartoComVistaParaPraia, QuartoComCafe
Objetivo: Adicionar funcionalidades extras aos quartos de maneira flexível.
<br>

### 4. Observer 👀
O padrão Observer é utilizado para notificar observadores (como o RegistradorDeLog) sobre mudanças nas reservas. Cada vez que uma reserva é realizada, os observadores são atualizados com a nova informação.

- Interface: IObservador
- Classe observadora: RegistradorDeLog
- Objetivo: Notificar mudanças no sistema para outros componentes interessados.
<br>

### 5. Singleton 🧑‍💻
O padrão Singleton é utilizado na classe SistemaReserva para garantir que haja apenas uma instância do sistema de reservas.

- Classe responsável: SistemaReserva
- Objetivo: Garantir que o sistema de reservas seja acessado por uma única instância.
<br>

## Testes 🧪
Os testes são implementados utilizando o framework XUnit. Abaixo estão alguns exemplos de testes implementados:

### 1. Teste de criação de quarto 🏠
- Objetivo: Verificar se a criação de quartos de diferentes tipos retorna o tipo correto de objeto.
- Classe de teste: QuartoFactoryTests
- Testa se a criação de quartos como Economico, Medio e Luxo retorna os objetos corretos.
- Testa se um tipo inválido de quarto lança uma exceção.

### 2. Teste de observador 📝
- Objetivo: Verificar se um observador pode ser corretamente adicionado ao sistema e receber notificações.
- Classe de teste: SistemaReservaTests
- Testa se o sistema de reservas notifica os observadores ao realizar alterações.

### 3. Teste de preço de quarto 💰
- Objetivo: Verificar se o preço dos quartos é calculado corretamente com base na estratégia de preço definida.
- Classe de teste: EstrategiaDePrecoTests
- Testa os preços para quartos Básicos, Médios e Luxos.


### 4. Teste de criação de quartos com adicionais 🏨
- Objetivo: Garantir que os quartos com adicionais são criados corretamente.
- Classe de teste: QuartoAdicionaisTest
- Descrição: Verifica se os quartos com adicionais, como QuartoComCafe e QuartoComVistaParaPraia, são instanciados corretamente a partir dos quartos básicos criados pela QuartoFactory.


## Como Executar o Projeto 🚀
1. Instalação 🔧

Clone o repositório do projeto:

git clone [Repositório no GitHub](https://github.com/GabrielPerosa/DesignPattern.git)

<br>


2. Executando o Projeto ▶️

Para rodar o projeto entre na pasta Hotelaria e utilize o comando:

```bash
dotnet run
```
Isso iniciará o sistema de reservas no console, onde você poderá interagir com as opções para reservar, listar, e remover reservas.

3. Executando os Testes ✅

Para rodar os testes unitários entre na pasta HotelariaTests:

```bash
dotnet test 
```
Isso executará todos os testes implementados no projeto, garantindo que o comportamento do sistema esteja correto.

------------------

# Conclusão 🎯

Este projeto aplica diversos padrões de design para criar um sistema modular e fácil de manter, além de garantir flexibilidade nas reservas e na adição de novos recursos. O uso dos padrões de projeto facilita a expansão e manutenção do sistema, tornando-o escalável e de fácil entendimento.




# Autores
<div align="center">
<table>
  <tr>
   <td align="center">
      <a href="https://github.com/GabrielPerosa">
        <img src="https://avatars.githubusercontent.com/u/159202121?v=4" width="70px;" alt="Gabriel Perosa"/><br>
        <sub>
          <b>Gabriel Perosa</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Giovani-RodriguesS">
        <img src="https://avatars.githubusercontent.com/u/121878338?v=4" width="70px;" alt="Giovani Rodrigues"/><br>
        <sub>
          <b>Giovani Rodrigues</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Anhaia09">
        <img src="https://avatars.githubusercontent.com/u/159202049?v=4" width="70px;" alt="Letícia Anhaia"/><br>
        <sub>
          <b>Letícia Anhaia</b>
        </sub>
      </a>
    </td>
    
  </tr>
</table>
</div>

