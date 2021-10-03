public class OpponentManager
{
    public void Add(MBUnitController pUnitController)
    {
        if (Opponent == null)
            Opponent = pUnitController;
    }

    public MBUnitController Opponent { private set; get; }
}
