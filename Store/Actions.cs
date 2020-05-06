using FluxorSample.Data;
using System.Collections.Generic;

namespace FluxorSample.Store
{
    public class FetchDomainObjectsCompleteAction
    {
        public FetchDomainObjectsCompleteAction(List<MyDomainObject> domainObjects)
        {
            DomainObjects = domainObjects;
        }

        public List<MyDomainObject> DomainObjects { get; }
    }


    public class SelectDomainObjectAction
    {
        public SelectDomainObjectAction(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
