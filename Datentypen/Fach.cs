using System;

public class Fach
{
	integer ID;
	string Name;
	string Beschreibung;
	List Begriffe;

	public  Fach(integer ID, string Name, string Beschreibung, List Begriffe)
	{
		this.ID = ID;
		this.Name = Name;
		this.Beschreibung = Beschreibung;
		this.Begriffe = Begriffe;

	}

    public override string ToString()
    {
		return ID + " " + Name + " " + Beschreibung;

	}

    public override bool Equals(object obj)
    {
        //return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

	public integer getID()
    {
		return ID;
    }

	public string getName()
    {
		return Name;
    }

	public void SetName(string name)
    {
		this.Name = name;
    }

	public string getBeschreibung()
    {
		return Beschreibung;
    }

	public void SetBeschreibung(string beschreibung)
    {
		this.Beschreibung = beschreibung;
    }
}
