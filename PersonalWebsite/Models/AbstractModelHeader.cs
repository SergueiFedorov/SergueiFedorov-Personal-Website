using System.Collections.Generic;

public abstract class AbstractModelHeader
{
    public string Type { get; private set; }
    public const string API_VERSION = "1.0";
    public List<object> Items { get; set; }

    public AbstractModelHeader(string type)
    {
        this.Type = type;
    }
}