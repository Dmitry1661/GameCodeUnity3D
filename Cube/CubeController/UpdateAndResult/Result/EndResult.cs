using UnityEngine;

class EndResult
{
    public EndResult(MBCubeObject pCube)
    {
        ResultDirectionHit Result = new DirectionHit(new DirectionRayCast(pCube).Ray, pCube).Result;

        if (Result.HitData.Equals(HitData.CUBE))
            new HitCube(pCube, Result.HitPosition);
        else if (Result.HitData.Equals(HitData.STOPPED))
            new HitStopped(pCube, Result.HitPosition);
    }
}

