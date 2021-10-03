public class StateRunning
{
    public StateRunning(bool pRunning)
    {
        Running = pRunning;
    }

    public void SetRunning(bool pRunning)
    {
        Running = pRunning;
    }

    public void Revers()
    {
        Running = !Running;
    }

    public bool Running { private set; get; }
}