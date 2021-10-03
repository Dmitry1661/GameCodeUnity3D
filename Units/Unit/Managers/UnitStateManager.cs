public class UnitStateManager
{
    public void Initilize(bool pRunning, int pHP, int pCountMotion)
    {
        if (IsInitilize == false && StateHP == null && StateRunning == null && StateMotion == null)
        {
            IsInitilize = true;

            StateRunning = new StateRunning(pRunning);
            StateHP = new StateHP(pHP);
            StateMotion = new StateMotion(pCountMotion);
        }
    }


    public bool IsInitilize { private set; get; }

    public StateHP StateHP { private set; get; }
    public StateRunning StateRunning { private set; get; }
    public StateMotion StateMotion { private set; get; }
}

