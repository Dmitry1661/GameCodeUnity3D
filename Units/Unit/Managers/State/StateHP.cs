public class StateHP
{
    public StateHP(int pHP)
    {
        MaxHP = CurrentHP = pHP;
    }

    public void AddHP(int pHP)
    {
        if (CurrentHP + pHP > MaxHP)
            CurrentHP = MaxHP;
    }
    public bool SubstractHP(int pHP)
    {
        if (CurrentHP - pHP <= 0)
            return false;
        else
            CurrentHP -= pHP;

        return true;
    }

    /// <summary>
    /// Максимальное количесво HP
    /// </summary>
    public int MaxHP { private set; get; }
    /// <summary>
    /// Запас сдоровья.
    /// </summary>
    public int CurrentHP { private set; get; }
}
