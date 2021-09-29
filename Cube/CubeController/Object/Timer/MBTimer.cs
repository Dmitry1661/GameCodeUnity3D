using UnityEngine;

public class MBTimer : MonoBehaviour
{
    public void Run()
    {
        IsRun = true;

        TimeStep = 0.0f;
    }

    public float Step()
    {
        IsRun = false;

        return TimeStep;
    }

    public void Update()
    {
        if (IsRun)
            TimeStep += Time.deltaTime;
    }

    public float TimeStep { private set; get; }
    public bool IsRun { private set; get; }
}
