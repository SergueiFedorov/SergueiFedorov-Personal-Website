class ProfileCollection : AbstractModelHeader
{
    public ProfileCollection()
        : base("PROFILE")
    {
        
    }
}

class ProfileModel
{
    public string Name { get; set; }
    public string AboutText { get; set; }
    public string ProfilePicture { get; set; }
}