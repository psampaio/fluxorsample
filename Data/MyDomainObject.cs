namespace FluxorSample.Data
{
    public class MyDomainObject
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public static MyDomainObject Empty => new MyDomainObject() { Id = "<id>", Name = "<name>" };
    }
}
