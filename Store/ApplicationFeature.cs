using Fluxor;
using FluxorSample.Data;
using System.Collections.Generic;

namespace FluxorSample.Store
{
    public class ApplicationFeature : Feature<ApplicationState>
    {
        public override string GetName() => "Application";

        protected override ApplicationState GetInitialState()
        {
            return new ApplicationState(new List<MyDomainObject>(), null);
        }
    }

}
