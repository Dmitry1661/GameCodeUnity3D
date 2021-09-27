public class CubeProperty
{
    public void Define(Action pAction, Location pLocation, Direction pDirection)
    {
        Action = pAction;
        Location = pLocation;
        Direction = pDirection;
    }
    public void Define(Action pAction)
    {
        Action = pAction;
    }
    public void Define(Action pAction, Direction pDirection)
    {
        Action = pAction;
        Direction = pDirection;
    }
    public void Define(Direction pDirection)
    {
        Direction = pDirection;
    }
    public void Define(Location pLocation)
    {
        Location = pLocation;
    }
    public void Define(Location pLocation, bool pBool)
    {
        if (pBool)
            Location |= pLocation;
        else
            Location ^= pLocation;
    }

    public Action Action { private set; get; }
    public Direction Direction { private set; get; }
    public Location Location { private set; get; }
}
