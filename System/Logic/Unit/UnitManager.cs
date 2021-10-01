using System.Collections.Generic;

public class UnitManager
{
    public UnitManager()
    {
        Units = new Dictionary<MBUnitController, UnitGameState>();
    }

    public void AddUnit(MBUnitController pUnitController, UnitGameState pBufferProgress)
    {
        Units.Add(pUnitController, pBufferProgress);
    }

    public Dictionary<MBUnitController, UnitGameState> Units { private set; get; }
}

