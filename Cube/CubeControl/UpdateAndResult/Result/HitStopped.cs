using UnityEngine;

/// <summary>
/// Обрабатывает косание обьекта STOPPED.
/// </summary>
struct HitStopped
{
    public HitStopped(MBCubeObject pCubeController, Vector3 pHitPosition)
    {
        // Когда куб "нарушил" дистанцию, слишком сильно приблизился, то мы исправим это сдесь.
        new TransformControl(
            pCubeController,
            new DistanceCondition(pCubeController, pHitPosition).Position
        );

        new PropertyControl(pCubeController, PropertyControlData.SET_FLAG_ACTION_NONE);
    }
}

