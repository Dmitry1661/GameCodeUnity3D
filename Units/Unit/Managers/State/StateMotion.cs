using UnityEngine;

public class StateMotion
{
    public StateMotion(int pCountMotion)
    {
        CountMotion = pCountMotion;
    }

    /// <summary>
    /// Вернет true, если ходы закончились.
    /// </summary>
    /// <returns></returns>
    public bool Increment()
    {
        bool result = false;

        if (NumberMotion < CountMotion)
            ++NumberMotion;
        else if (NumberMotion == CountMotion)
        {
            result = true;
            Reset();
        }

        return result;
    }

    public void Decrement()
    {
        if (NumberMotion > 0)
            --NumberMotion;
    }

    public void Reset()
    {
        NumberMotion = 0;
    }

    public int CountMotion { private set; get; }
    public int NumberMotion { private set; get; }
}
