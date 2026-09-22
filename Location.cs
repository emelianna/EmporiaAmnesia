class Location
{
    public string Name {get; protected set;} = "";
    public string Description {get; protected set;} = "";

    public List<Item> Items = [];

  public string[] Directions { get; protected set; } = [""];
}