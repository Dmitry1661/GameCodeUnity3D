struct UnitStateControlData
{
    /// <summary>
    /// Инициализировать State Unit'a.(bool Running, int HP, int Motion)
    /// </summary>
    public const int INITIALIZE = 0;

    /// <summary>
    /// Узнаем можем ли мы совершить ход.
    /// </summary>
    public const int HAS_RUNNING = 1;

    /// <summary>
    /// Защитать ход.Если ходы закончились значит передает ход оппоненту.
    /// </summary>
    public const int INCREMENT_MOTION = 2;
}
