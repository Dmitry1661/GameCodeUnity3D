/// <summary>
/// Связь с создателем.
/// </summary>
public class ConnectTheMaker
{
    public MBUnitController UnitController { private set; get; }

    public void AddUnit(MBUnitController pUnitControler)
    {
        if (UnitController == null)
            UnitController = pUnitControler;
    }
}
