using System;

public class Inscriere : Entitate<long>
{
	public long idCopil { get; set; }
	public long idProba { get; set; }

    public Inscriere(long idCopil, long idProba)
    {
        this.idCopil = idCopil;
        this.idProba = idProba;
    }
}
