using System.Collections.Generic;

public abstract class AbstractModelCollection<T> : AbstractModelHeader
{
    public List<T> Items { get; set; }

    public AbstractModelCollection(string type)
        : base(type)
    {
        this.Items = new List<T>();
    }
}