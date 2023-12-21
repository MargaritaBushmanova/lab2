using System;

public class Composition
{
	string author;
	string song;
	public Composition(string _author, string _song)
	{
        author= _author;
		song = _song;

    }
    public override string ToString()
	{
		return author + " - " + song;
    }
}
