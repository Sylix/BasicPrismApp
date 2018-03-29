using Prism.Mvvm;
using Prism.Navigation;

namespace BasicPrismApp.ViewModels
{
    public class LastPageViewModel : BindableBase, INavigationAware
    {
        private string mensagem = string.Empty;
        public string Mensagem
        {
            get => mensagem;
            set => SetProperty(ref mensagem, value);
        }
        public LastPageViewModel()
        {
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Mensagem = $"O parametro recebido foi: {parameters["Parametro"]}";
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
