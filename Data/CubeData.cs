public struct CubeData
{
    public const int POWER_ATTACK = 10;

    /// <summary>
    /// Скорость перемещение куба.
    /// </summary>
    public const float SPEED_MOVE = 10.0f;

    /// <summary>
    /// Дистанция между кубами.
    /// </summary>
    public const float DISTANCE = 1.083f;
    /// <summary>
    /// Значение для сравнения с дистанцией полученой от HIT.
    /// </summary>
    public const float HIT_DISTANCE = 1.0831f; // ЗАПЛАТКА.

    /// <summary>
    /// Папка в которой хранятся префабы кубов.
    /// </summary>
    private const string CUBE_PATH = "Cubes/";

    /// <summary>
    /// Имя стандартного куба.
    /// </summary>
    public const string DEFAULT_CUBE_NAME = "DefaultCube";
    public const string RED_CUBE_NAME = "RedCube";

    /// <summary>
    /// Путь до стандартного куба.
    /// </summary>
    public const string DEFAULT_CUBE_PATH = CUBE_PATH + DEFAULT_CUBE_NAME;
    public const string RED_CUBE_PATH = CUBE_PATH + RED_CUBE_NAME;

    /// <summary>
    /// У любого обьекта в проекте данная позиция невозможна.
    /// </summary>
    public const float HIT_POSITION_X_NONE = -1.0f;
    /// <summary>
    /// У любого обьекта в проекте данная позиция невозможна.
    /// </summary>
    public const float HIT_POSITION_Y_NONE = -1.0f;
    /// <summary>
    /// У любого обьекта в проекте данная позиция невозможна.
    /// </summary>
    public const float HIT_POSITION_Z_NONE = -1.0f;

    /// <summary>
    /// Шаг времени перед созданием нового куба, при CreatingLevel.
    /// </summary>
    public const float TIME_STEP_CREATING_CUBE = 0.25f;

    /// <summary>
    /// Если время нажатие на куб меньше данного значения, то это простое нажание, 
    /// иначе это запрос на получение информации.
    /// </summary>
    public const float TIME_STEP_CLICK_MOVE = 1.0f;
}
