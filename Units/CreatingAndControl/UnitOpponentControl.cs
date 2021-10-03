class UnitOpponentControl
{
    public UnitOpponentControl(MBUnitController pUnit, int pCommand, object pObject = null)
    {
        switch(pCommand)
        {
            case OpponentControlData.ADD_OPPONENT:
                if (pObject is string)
                    pUnit.Event(new AddOpponent((string)pObject));
                break;
        }
    }
}
