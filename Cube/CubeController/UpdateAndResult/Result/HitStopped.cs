using UnityEngine;

/// <summary>
/// Обрабатывает косание обьекта STOPPED.
/// </summary>
class HitStopped
{
    public HitStopped(MBCubeObject pCube, Vector3 pHitPosition)
    {
        new PropertyControl(pCube, PropertyControlData.SET_FLAG_ACTION_NONE, pHitPosition);
    }
}

