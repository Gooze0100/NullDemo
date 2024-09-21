namespace NullDemo;

// you can also activate nullable option file by file if you have huge applications
// there are 9 different options with this nullable options
#nullable enable //annotations //warnings
public class PersonModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsValid { get; set; }

    public PersonModel()
    {
        Name = "";
    }
}
#nullable restore //annotations //warnings

public class AdderssModel
{
    public int StreetAddres { get; set; }
    public string City { get; set; }
}