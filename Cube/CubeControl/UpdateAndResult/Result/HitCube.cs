using UnityEngine;

/// <summary>
/// Обрабатывает косание обьекта CUBE.
/// </summary>
struct HitCube
{
    public HitCube(MBCubeObject pCube, Vector3 pHitPosition)
    {
        new EnvironmentControl(pCube, EnvironmentControlData.HAS_NEED_SHIFT);
        /*
        if (new EnvironmentControl(pCube, EnvironmentControlData.HAS_NEED_SHIFT).Result)
        {
            Debug.Log(1);
        }
        */
        //new EnvironmentControl(pCube, EnvironmentControlData.MAKE_SHIFT);
        //else
        //new PropertyControl(pCube, PropertyControlData.SET_FLAG_ACTION_NONE);
    }
}

