using UnityEngine;

/// <summary>
/// Обрабатывает косание обьекта CUBE.
/// </summary>
class HitCube
{
    public HitCube(MBCubeObject pCube, Vector3 pHitPosition)
    {
        new UnitBoardsControl(pCube, BoardsControlData.BOARDS_DOWN);

        if (new CubeEnvironmentControl(pCube, EnvironmentControlData.HAS_NEED_SHIFT).Result)
        {
            new CubeEnvironmentControl(pCube, EnvironmentControlData.MAKE_SHIFT);
        }
        else
            new CubePropertyControl(pCube, PropertyControlData.SET_FLAG_ACTION_NONE, pHitPosition);
    }
}

