using System;

public class Lernstunde
{
	private integer ID;
	private string Name;
	private List<Begriff> Begriffe;

	public Lernstunde(List<Begriff> Begriffe){
		this.Begriffe = Begriffe;
	}

    public override string ToString()
    {
		return ID + " " + Name;
    }

    public override bool Equals(object obj)
    {
        //return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        //return base.GetHashCode();
    }
}
