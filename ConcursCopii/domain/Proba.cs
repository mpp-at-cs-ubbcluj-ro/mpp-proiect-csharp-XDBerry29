using System;

public class Proba: Entitate<long>
{
    public Proba(string nume, int varsta_min, int varsta_max)
    {
        this.nume = nume;
        this.varsta_min = varsta_min;
        this.varsta_max = varsta_max;
    }

    public string nume { get; set; }
	public int varsta_min { get; set; }

	public int varsta_max { get; set; }
}
