using UnityEngine;

class SendTheCubeToTheField
{
    /// <summary>
    /// Отправить куб на поле.
    /// </summary>
    /// <param name="pCube"></param>
    public SendTheCubeToTheField(MBCubeController pCube)
    {
        if (new PropertyControl(pCube, PropertyControlData.HAS_LOCATION_PANEL).Result)
        {
            new PropertyControl(pCube, PropertyControlData.SEND_THE_CUBE_TO_THE_FIELD);

            new UnitControl(pCube, UnitControlData.BOARDS_RAISE);
        }
    }
}
