using UnityEngine;

class SendTheCubeToTheField
{
    /// <summary>
    /// Отправить куб на поле.
    /// </summary>
    /// <param name="pCube"></param>
    public SendTheCubeToTheField(MBCubeController pCube)
    {
        if (new CubePropertyControl(pCube, PropertyControlData.HAS_LOCATION_PANEL).Result)
        {
            new CubePropertyControl(pCube, PropertyControlData.SEND_THE_CUBE_TO_THE_FIELD);

            new UnitBoardsControl(pCube, BoardsControlData.BOARDS_RAISE);
        }
    }
}
