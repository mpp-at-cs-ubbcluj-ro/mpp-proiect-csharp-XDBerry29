using System;

public class Copil: Entitate<long>
{
    public Copil(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string name { get; set; }
	public int age { get; set; }

}
