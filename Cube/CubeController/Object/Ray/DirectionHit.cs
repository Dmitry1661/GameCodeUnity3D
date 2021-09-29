using UnityEngine;

public struct ResultDirectionHit
{
    public ResultDirectionHit(Vector3 pHitPosition, string pHitData)
    {
        HitPosition = pHitPosition;
        HitData = pHitData;
    }

    public Vector3 HitPosition { private set; get; }
    public string HitData { private set; get; }
}

public class DirectionHit
{
    /// <summary>
    /// При достижении обьекта STOPPED или другого CUBE получим в результате его позицию 
    /// и тип обькта с которым произошло косание. Дистанция косания определена в CubeData.DISTANCE.
    /// </summary>
    /// <param name="pRay">Луч.</param>
    /// <param name="pCube">Контроллер куба.</param>
    public DirectionHit(Ray pRay, MBCubeObject pCube)
    {
        Result = new ResultDirectionHit(new Vector3(), HitData.NONE);

        Vector3 position = new TransformControl(pCube).Position;

        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(pRay, out hit))
        {
            if (hit.collider.TryGetComponent(out Transform aTransform))
            {
                Vector3 posHit = aTransform.position;

                float distance = Vector3.Distance(posHit, position);

                if (distance <= CubeData.DISTANCE)
                {
                    if (hit.collider.CompareTag(HitData.CUBE))
                        Result = new ResultDirectionHit(new DistanceCondition(pCube, posHit).Position, HitData.CUBE);
                    else if (hit.collider.CompareTag(HitData.STOPPED))
                        Result = new ResultDirectionHit(new DistanceCondition(pCube, posHit).Position, HitData.STOPPED);
                }
            }
        }
    }

    public ResultDirectionHit Result { private set; get; }
}
