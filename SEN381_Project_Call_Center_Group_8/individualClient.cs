using System;

public class individualClient
{
    private string indiID;
    private string name;
    private string surname;
    private string role;
    private string serviceTypeID;

    public string IndiID { get => indiID; set => indiID = value; }
    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public string Role { get => role; set => role = value; }
    public string ServiceTypeID { get => serviceTypeID; set => serviceTypeID = value; }

    public individualClient()
    {
    }

    public individualClient(string id, string nm, string surnm, string role, string serviveTyp)
    {
        this.indiID = id;
        this.name = nm;
        this.surname = surnm;
        this.role = role;
        this.serviceTypeID = serviveTyp;
    }

}
