using TDD.App;

namespace TDD.Test;

// clase escrita por mi
public class ModoTest: IModo 
{
    public string GetMode()
    {
        return "decimal";
    }

    public string GetName()
    {
        return "modo";
    }
}