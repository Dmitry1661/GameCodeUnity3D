using System.Collections.Generic;
using UnityEngine;

class NeighborsRayCast
{
    /// <summary>
    /// Направляет лучи вверх, низ, лево, право.
    /// </summary>
    /// <param name="MBCubeObject"></param>
    public NeighborsRayCast(MBCubeObject pCube)
    {
        Transform transform = new TransformControl(pCube).Transform;
        Vector3 position = new TransformControl(pCube).Position;

        Rays = new Dictionary<Direction, Ray>()
        {
            { Direction.Upper, new Ray(position, transform.up) },
            { Direction.Lower, new Ray(position, -transform.up) },
            { Direction.Left,  new Ray(position, -transform.right) },
            { Direction.Right, new Ray(position, transform.right) }
        };
    }

    public Dictionary<Direction, Ray> Rays { private set; get; }
}
