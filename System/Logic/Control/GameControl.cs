struct GameControlData
{
    /// <summary>
    /// Добавить Unit в UnitManager.
    /// </summary>
    public const int ADD_UNIT = 0;
}

class GameControl
{
    public GameControl(MBUnitController pUnit, int pCommand, object pObject)
    {
        switch (pCommand)
        {
            case GameControlData.ADD_UNIT:
                if (pObject != null && pObject is bool)
                    pUnit.GameSystem.Logic.UnitManager.AddUnit(pUnit, new UnitGameState((bool)pObject));
                break;
        }
    }
}
