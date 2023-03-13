using System;

public class Organizator: Entitate<long>
{
    public Organizator(string username, string password)
    {
        this.username = username;
        this.password = password;
    }

    public string username { get; set; }
	public string password { get; set; }

}
