class IncrementMotion : IUnitEvent
{
    public void Event(MBUnitController pUnit)
    {
        if (pUnit.StateManager.StateMotion.Increment())
        {
            pUnit.StateManager.StateRunning.Revers();
            pUnit.OpponentManager.Opponent.StateManager.StateRunning.Revers();
        }
    }
}
