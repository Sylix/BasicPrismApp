using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System.Threading.Tasks;

namespace BasicPrismApp.ViewModels
{
    public class LoginPageViewModel : BindableBase
	{
	    private readonly INavigationService navigationService;
        private readonly IPageDialogService pageDialogService;

        private string username = string.Empty;
	    public string Username
	    {
	        get => username;
	        set => SetProperty(ref username, value);
	    }

	    private DelegateCommand loginCommand;

	    public DelegateCommand LoginCommand => loginCommand ?? 
         (loginCommand = new DelegateCommand(async () => await LoginCommandExecuteAsync()));

        public LoginPageViewModel(INavigationService navigationService,
                                  IPageDialogService pageDialogService)
        {
            this.navigationService = navigationService;
            this.pageDialogService = pageDialogService;
        }

	    private async Task LoginCommandExecuteAsync()
	    {
	        if (string.IsNullOrWhiteSpace(username))
	        {
	            await pageDialogService.DisplayAlertAsync("Login",
	                "Favor informa o nome do usuário",
	                "Ok");
                return;
	        }
            if (username == "Brian")
	        {
	            await pageDialogService.DisplayAlertAsync("Login",
	                                                      $"{username}... Acho que esse cara entende alguma coisa de Prism!",
	                                                      "Ok");
            }

	        //await navigationService.NavigateAsync("NavigationPage/MainPage");
	        await navigationService.NavigateAsync("/NavigationPage/MainPage");
        }
    }
}
