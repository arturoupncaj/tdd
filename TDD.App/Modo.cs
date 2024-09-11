namespace TDD.App;

// esta es una clase externa
public class Modo: IModo
{
    public string Mode;

    public string GetMode()
    {
        throw new Exception();
        // se conecta a la api de sunat/
        return this.Mode;
    }

    public string GetName()
    {
        return "modo";
    }
}