namespace DICEROLLER
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Random rnd = new Random();

            Console.WriteLine("Generating 10 random numbers:");

            for (uint ctr = 1; ctr <= 10; ctr++)
                Console.WriteLine($"{rnd.Next(),15:N0}");
        }
    }

}





























/*
 * NOME DO PROJETO: DICEROLLER
## Instruções
- Implemente o que é pedido:
    - Criação do layout seguindo o layout no figma.
    - Implementar o método de rolagem utilizando o método Random.
    - Implementar uma dropbox para seleção da quantidade de lados do dado.
- Entregar a atividade em dupla através do MS Teams.


## Critério de avaliação
- MB. Completou todas as funcionalidades pedidas.
- B. Completou as seguintes funcionalidades:
    - [ ] rolagem de dados sem seleção de opções
    - [ ] fez corretamente o [layout da aplicação](https://www.figma.com/file/Or6Kna0mOCp7RR7bYCdSvr/Untitled?type=design&node-id=0%3A1&mode=design&t=X6ajUIfgt3KHLQbJ-1)
    - [ ] implementou corretamente o método de rolagem usando a função
    [Random](https://learn.microsoft.com/pt-br/dotnet/api/system.random.next?view=net-7.0).
- R. Implementou a rolagem para um dado de 10 lados (d10) e fez o layout inteiro.
- I. Não conseguiu terminar o layout e/ou o método de rolagem.

## Links úteis
- [Figma](https://www.figma.com/file/Or6Kna0mOCp7RR7bYCdSvr/Untitled?type=design&node-id=0%3A1&mode=design&t=X6ajUIfgt3KHLQbJ-1)

- [Método Math Random](https://learn.microsoft.com/pt-br/dotnet/api/system.random.next?view=net-7.0)

- [Picker](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/picker)