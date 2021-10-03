class InitializeStateManager : IUnitEvent
{
    public InitializeStateManager(bool pRunning, int pHP, int pMotion)
    {
        HP = pHP;
        Motion = pMotion;
        Running = pRunning;
    }

    public void Event(MBUnitController pUnit)
    {
        pUnit.StateManager.Initilize(Running, HP, Motion);
    }

    public int HP { private set; get; }
    public int Motion { private set; get; }
    public bool Running { private set; get; }
}
