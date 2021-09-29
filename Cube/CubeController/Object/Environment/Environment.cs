using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Окружающая среда.
/// </summary>
public class Environment
{
    public Environment(MBCubeObject pCube)
    {
        Cube = pCube;
        Neighbors = new Dictionary<Direction, GameObject>();
    }

    public bool Event(INeighborsEvent pNeighborsEvent)
    {
        // Обнаружим соседей.
        Neighbors = new NeighborsHit(Cube, new NeighborsRayCast(Cube).Rays).Neighbors;

        return pNeighborsEvent.Survey(this);
    }

    public MBCubeObject Cube { private set; get; }
    public Dictionary<Direction, GameObject> Neighbors { private set; get; }
}
