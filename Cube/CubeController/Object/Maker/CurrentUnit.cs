/// <summary>
/// Связь с текущим Running Unit.
/// </summary>
public class CurrentUnit
{
    public MBUnitController UnitController { private set; get; }

    public void AddUnit(MBUnitController pUnitControler)
    {
        UnitController = pUnitControler;
    }
}
