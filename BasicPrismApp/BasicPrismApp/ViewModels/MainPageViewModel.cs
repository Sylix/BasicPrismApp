using BasicPrismApp.Repositories;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Threading.Tasks;

namespace BasicPrismApp.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private readonly INavigationService navigationService;
        private readonly BasicRepository basicRepository;
        private DelegateCommand<string> selecionarCommand;
        public DelegateCommand<string> SelecionarCommand => selecionarCommand ?? (selecionarCommand = new DelegateCommand<string>(async (parametro) => await SelecionarComandExecuteAsync(parametro)));

        public MainPageViewModel(INavigationService navigationService, BasicRepository basicRepository)
        {
            this.navigationService = navigationService;
            this.basicRepository = basicRepository;
        }

        private async Task SelecionarComandExecuteAsync(string parametro)
        {
            var parameter = new NavigationParameters
            {
                { "Parametro", parametro }
            };
            await navigationService.NavigateAsync("LastPage", parameter);
        }
    }
}