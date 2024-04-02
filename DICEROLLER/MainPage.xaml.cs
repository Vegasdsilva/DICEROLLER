using Microsoft.Extensions.Options;

namespace DICEROLLER
{
    public partial class MainPage : ContentPage
    {
        int valor = 0;
        public MainPage()
        {
            InitializeComponent();
            SidesPicker.SelectedIndex = 0;
        }


        private void RollBtn_Clicked(object sender, EventArgs e)
        {
            // Pegar o valor que foi selecionado pelo usuario no picker
            valor = Convert.ToInt32(SidesPicker.SelectedItem) ;
            //Jogar esse valor em uma variavel
            //Sortear o numero em um dado utilizando 
            var umvalor = 0;
            umvalor = new Random().Next(1, valor+1);
            //Exibir o valor para o usuario na ResultLabel
            ResultLabel.Text = umvalor.ToString();
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
*/