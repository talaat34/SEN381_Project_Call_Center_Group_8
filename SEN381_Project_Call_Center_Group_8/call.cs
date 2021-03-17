

using System;

public class call
{
    private string callLength;
    private string callTime;
    private string indiID;
    private string busiID;
    private string empiID;



    public string CallLength { get => callLength; set => callLength = value; }
    public string CallTime { get => callTime; set => callTime = value; }
    public string IndiID { get => indiID; set => indiID = value; }
    public string BusiID { get => busiID; set => busiID = value; }
    public string EmpID { get => empiID; set => empiID = value; }

    public call()
    {

    }
    public call(string length, string time, string indID, string busID, string empID)
    {
        this.callLength = length;
        this.callTime = time;
        this.indiID = indID;
        this.busiID = busID;
        this.empiID = empID;
    }
}
