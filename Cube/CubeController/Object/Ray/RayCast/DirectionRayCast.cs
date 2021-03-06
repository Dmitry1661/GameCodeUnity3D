using UnityEngine;

public class DirectionRayCast
{
    /// <summary>
    /// Возращает направление луча в зависимости от направления куба.
    /// </summary>
    /// <param name="pCubeController"></param>
    public DirectionRayCast(MBCubeObject pCubeController)
    {
        Transform transform = new CubeTransformControl(pCubeController).Transform;
        Vector3 position = new CubeTransformControl(pCubeController).Position;

        if (new CubePropertyControl(pCubeController, PropertyControlData.HAS_DIRECTION_FLAG, Direction.Upper).Result) 
            Ray = new Ray(position, transform.up);
        else if (new CubePropertyControl(pCubeController, PropertyControlData.HAS_DIRECTION_FLAG, Direction.Lower).Result) 
            Ray = new Ray(position, -transform.up);
        else if (new CubePropertyControl(pCubeController, PropertyControlData.HAS_DIRECTION_FLAG, Direction.Left).Result) 
            Ray = new Ray(position, -transform.right);
        else if (new CubePropertyControl(pCubeController, PropertyControlData.HAS_DIRECTION_FLAG, Direction.Right).Result) 
            Ray = new Ray(position, transform.right);
    }

    public Ray Ray { private set; get; }
}

