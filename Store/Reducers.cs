using Fluxor;

namespace FluxorSample.Store
{
    public static class Reducers
    {
        [ReducerMethod]
        public static ApplicationState Reduce(ApplicationState state, FetchDomainObjectsCompleteAction action)
        {
            return new ApplicationState(action.DomainObjects, state.SelectedDomainObjectId);
        }

        [ReducerMethod]
        public static ApplicationState Reduce(ApplicationState currentState, SelectDomainObjectAction action)
        {
            return new ApplicationState(currentState.DomainObjects, action.Id);
        }
    }
}
