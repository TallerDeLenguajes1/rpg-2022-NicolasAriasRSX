namespace RPG;
public class caracteristicas
{
    Random numRan= new Random();

    float velocidad; // entre 1 y 10
    float destreza; // entre 1 y 5
    float fuerza; // entre 1 y 10
    float nivel; // entre 1 y 10
    float armadura; // entre 1 y 10

    public caracteristicas()
    {
        this.velocidad = (float)numRan.Next(10,101) / 100;
        this.destreza = (float)numRan.Next(10,501) / 100;
        this.fuerza = (float)numRan.Next(10,101) / 100;
        this.nivel = (float)numRan.Next(10,101) / 100;
        this.armadura = (float)numRan.Next(10,101) / 100;
    }
}