using UnityEngine;

public class DistanceCondition
{
    /// <summary>
    /// Преобразовать дистанцию определениую в CubeData.DISTANCE .
    /// </summary>
    /// <param name="pCubeController"></param>
    /// <param name="pPosition"></param>
    public DistanceCondition(MBCubeObject pCubeController, Vector3 pPosition)
    {
        if (new PropertyControl(pCubeController, PropertyControlData.HAS_DIRECTION_FLAG, Direction.Upper).Result)
            Position = new Vector3(pPosition.x, pPosition.y - CubeData.DISTANCE, pPosition.z);
        else if (new PropertyControl(pCubeController, PropertyControlData.HAS_DIRECTION_FLAG, Direction.Lower).Result)
            Position = new Vector3(pPosition.x, pPosition.y + CubeData.DISTANCE, pPosition.z);
        else if (new PropertyControl(pCubeController, PropertyControlData.HAS_DIRECTION_FLAG, Direction.Left).Result)
            Position = new Vector3(pPosition.x + CubeData.DISTANCE, pPosition.y, pPosition.z);
        else if (new PropertyControl(pCubeController, PropertyControlData.HAS_DIRECTION_FLAG, Direction.Right).Result)
            Position = new Vector3(pPosition.x - CubeData.DISTANCE, pPosition.y, pPosition.z);
    }

    public Vector3 Position { private set; get; }
}

