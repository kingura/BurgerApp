using System;

class Burger
{
    private string name;
    DateTime starttime, endtime;

    public string Name { get => name; set => name = value; }
    public DateTime Starttime { get => starttime; set => starttime = value; }
    public DateTime Endtime { get => endtime; set => endtime = value; }

    public Burger(string name)
    {
        this.Name = name;
        Starttime = DateTime.Now;
    }

}