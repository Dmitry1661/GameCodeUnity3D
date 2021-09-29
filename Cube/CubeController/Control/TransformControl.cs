using UnityEngine;

class TransformControl
{
    public TransformControl(MBCubeObject pCubeController)
    {
        Transform = pCubeController.Transform.Transform;
        Position = pCubeController.Transform.Position;
    }

    /// <summary>
    /// Произвести движение.
    /// </summary>
    /// <param name="pCubeController"></param>
    /// <param name="pDeltaTime"></param>
    public TransformControl(MBCubeObject pCubeController, float pDeltaTime = -1)
    {
        Transform = pCubeController.Transform.Transform;
        Position = pCubeController.Transform.Position;

        pCubeController.Transform.NextPosition(
            new StepPosition(pCubeController.Property.Direction,
                                    pCubeController.Transform.Position,
                                    pDeltaTime,
                                        CubeData.SPEED_MOVE).ResultPosition
            );
    }
    /// <summary>
    /// Установить позицию кубу.
    /// </summary>
    /// <param name="pCubeController">Констроллер куба.</param>
    /// <param name="pNextPosition">Позицию в конторую нужно поставить куб.</param>
    public TransformControl(MBCubeObject pCubeController, Vector3 pNextPosition)
    {
        Transform = pCubeController.Transform.Transform;
        Position = pCubeController.Transform.Position;

        pCubeController.Transform.NextPosition(pNextPosition);
    }

    public Transform Transform { private set; get; }
    public Vector3 Position { private set; get; }
}
