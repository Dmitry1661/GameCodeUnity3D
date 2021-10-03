class ToConfigCubeManager : IUnitEvent
{
    public ToConfigCubeManager(string pNamePositionRespown, string[] pCubeNameArray)
    {
        NamePositionRespown = pNamePositionRespown; 
        CubeNameArray = pCubeNameArray; 
    }

    public void Event(MBUnitController pUnitController)
    {
        // Запишим место респауна кубов.
        pUnitController.CubeManager.AddRespownPosition(NamePositionRespown + PlayerData.PLAYER_RESPOWN);

        // Запишим все кубы которые мы можем использовать.
        for (int i = 0; i < CubeNameArray.Length; ++i)
        {
            pUnitController.CubeManager.AddCube(CubeNameArray[i], CubeData.CUBE_PATH);
        }
    }

    /// <summary>
    /// Имя обьекта на месте которого произадет респаун.
    /// </summary>
    public string NamePositionRespown { private set; get; }

    /// <summary>
    /// Массив имен префабов кубов которые мы прогрузим.
    /// </summary>
    public string[] CubeNameArray { private set; get; }
}
