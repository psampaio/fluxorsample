using Fluxor;
using FluxorSample.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FluxorSample.Store
{
    public class StoreInitializedEffect : Effect<StoreInitializedAction>
    {
        //TODO: Simulate initial data loading
        protected override Task HandleAsync(StoreInitializedAction action, IDispatcher dispatcher)
        {
            var domainObjects = new List<MyDomainObject>()
            {
                new MyDomainObject()
                {
                    Id = "testid",
                    Name = "Test Name"
                }
            };
            dispatcher.Dispatch(new FetchDomainObjectsCompleteAction(domainObjects));

            return Task.CompletedTask;
        }
    }
}
