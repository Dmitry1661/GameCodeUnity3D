using UnityEngine;

public class StepPosition 
{
    public StepPosition(Direction pDirection, Vector3 pStartPosition, float pTimeStep, float pSpeed)
    {
        if (pDirection.HasFlag(Direction.Upper))
            ResultPosition = new Vector3(pStartPosition.x,
                                         pStartPosition.y + (pTimeStep * pSpeed),
                                         pStartPosition.z);
        else if (pDirection.HasFlag(Direction.Lower))
            ResultPosition = new Vector3(pStartPosition.x,
                                         pStartPosition.y - (pTimeStep * pSpeed),
                                         pStartPosition.z);
        else if (pDirection.HasFlag(Direction.Right))
            ResultPosition = new Vector3(pStartPosition.x + (pTimeStep * pSpeed),
                                         pStartPosition.y,
                                         pStartPosition.z);
        else if (pDirection.HasFlag(Direction.Left))
            ResultPosition = new Vector3(pStartPosition.x - (pTimeStep * pSpeed),
                                         pStartPosition.y,
                                         pStartPosition.z);
        else
            ResultPosition = pStartPosition;
    }

    public Vector3 ResultPosition { private set; get; }
}
