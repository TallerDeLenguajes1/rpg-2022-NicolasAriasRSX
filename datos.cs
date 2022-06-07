namespace RPG;
public class datos
{
    Random numRand= new Random();
    public enum Tipos
    {
        Humano, Orco, Brujo, Elfo, Enano
    }
    public enum Nombres
    {
        Juan, jose, Mauro, Lucas, Pedro, Max, Sebastian
    }
    public enum Apodos
    {
        Capricho, Legasi, NoobMaster, BobSponja, MiRey, CasiGamer, ElOtaku, KidRat, DonOscuro
    }

    private Tipos tipo;
    private Nombres nombre;
    private Apodos apodo;
    private DateTime fechaNac;
    private int edad;
    private float salud;

    public datos()
    {
        this.tipo = (Tipos) numRand.Next(4);
        this.nombre = (Nombres) numRand.Next(6);
        this.apodo = (Apodos) numRand.Next(8);
        this.fechaNac = new DateTime(numRand.Next(1800,2001), numRand.Next(1,12), numRand.Next(1,31));
        this.edad = Edad();
        this.salud = 100;
    }
    public int Edad()
    {
        int edad;
        DateTime fechaActual= DateTime.Now;
        edad = fechaActual.Year - fechaNac.Year;
        if (fechaActual.Month < fechaNac.Month && fechaActual.Day < fechaNac.Day)
        {
            edad--;
        }
        return edad;
    }
}