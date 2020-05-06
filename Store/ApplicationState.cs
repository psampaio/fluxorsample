using FluxorSample.Data;
using System.Collections.Generic;
using System.Linq;

namespace FluxorSample.Store
{
    public class ApplicationState
    {
        public ApplicationState(List<MyDomainObject> domainObjects, string selectedDomainObjectId)
        {
            DomainObjects = domainObjects;
            SelectedDomainObjectId = selectedDomainObjectId;
        }

        public List<MyDomainObject> DomainObjects { get; }

        public string SelectedDomainObjectId { get; }

        public MyDomainObject SelectedDomainObject => DomainObjects.SingleOrDefault(d => d.Id == SelectedDomainObjectId) ?? MyDomainObject.Empty;

    }
}