/// <summary>
/// Состояние Unit.
/// </summary>
public class UnitGameState
{
    public UnitGameState(bool pRunning)
    {
        Running = pRunning;
    }

    public void SetRunning(bool pRunning)
    {
        Running = pRunning;
    }

    public bool Running { private set; get; }
}

