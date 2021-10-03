struct PropertyControlData
{
    /// <summary>
    /// Поднят ли флаг Action.None у куба. 
    /// </summary>
    public const int HAS_FLAG_ACTION_NONE = 0;

    /// <summary>
    /// Поднят ли флаг Action.Move у куба. 
    /// </summary>
    public const int HAS_FLAG_ACTION_MOVE = 1;

    /// <summary>
    /// Установить флаг Action.MOVE у куба.
    /// </summary>
    public const int SET_FLAG_ACTION_MOVE = 2;

    /// <summary>
    /// Установить флаг Action.NONE у куба.
    /// </summary>
    public const int SET_FLAG_ACTION_NONE= 3;

    /// <summary>
    /// Проверить флаг Direction на соответсвие.
    /// </summary>
    public const int HAS_DIRECTION_FLAG = 4;

    /// <summary>
    /// Узнать находится ли куб на панели.
    /// </summary>
    public const int HAS_LOCATION_PANEL = 5;

    /// <summary>
    /// Установить что куб находится в панеле.
    /// </summary>
    public const int SET_LOCATION_PANEL = 6;

    /// <summary>
    /// Отправить куб на поле.
    /// </summary>
    public const int SEND_THE_CUBE_TO_THE_FIELD = 7;

    /// <summary>
    /// Установить Location.Choice, Action.Move и Direction.
    /// </summary>
    public const int CREATING_CUBE = 100;
}
