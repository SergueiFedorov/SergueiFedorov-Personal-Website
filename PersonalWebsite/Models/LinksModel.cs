public class LinksModelCollection : AbstractModelHeader
{
    public LinksModelCollection()
        : base("MAIN_SITE_LINKS")
    {

    }
}

public class LinksModel
{
    public string Text { get; set; }
    public string Link { get; set; }
}