using Fluxor;
using Fluxor.Blazor.Web.Components;
using FluxorSample.Data;
using FluxorSample.Store;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;

namespace FluxorSample
{
    public abstract class BasePage : FluxorComponent
    {
        [Parameter]
        public string myDomainObjectId { get; set; }

        [Inject]
        protected IState<ApplicationState> AppState { get; set; } //TODO: change to private and stops working

        [Inject]
        private IStore Store { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        [Inject]
        private IDispatcher Dispatcher { get; set; }

        public MyDomainObject MyDomainObject => AppState.Value.SelectedDomainObject;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await Store.Initialized.ConfigureAwait(true);

                if (string.IsNullOrEmpty(myDomainObjectId))
                {
                    NavigationManager.NavigateTo(NavigationManager.BaseUri);
                }
                else if (MyDomainObject?.Id != myDomainObjectId)
                {
                    SelectDomainObject();
                }
            }
        }

        private void SelectDomainObject()
        {
            if (AppState.Value.DomainObjects.Any(m => m.Id == myDomainObjectId))
            {
                Dispatcher.Dispatch(new SelectDomainObjectAction(myDomainObjectId));
            }
            else
            {
                NavigationManager.NavigateTo(NavigationManager.BaseUri);
            }
        }
    }
}
