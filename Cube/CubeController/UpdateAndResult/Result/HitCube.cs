using UnityEngine;

/// <summary>
/// Обрабатывает косание обьекта CUBE.
/// </summary>
class HitCube
{
    public HitCube(MBCubeObject pCube, Vector3 pHitPosition)
    {
        if (new EnvironmentControl(pCube, EnvironmentControlData.HAS_NEED_SHIFT).Result)
        {
            new EnvironmentControl(pCube, EnvironmentControlData.MAKE_SHIFT);
        }
        else
            new PropertyControl(pCube, PropertyControlData.SET_FLAG_ACTION_NONE, pHitPosition);
    }
}

