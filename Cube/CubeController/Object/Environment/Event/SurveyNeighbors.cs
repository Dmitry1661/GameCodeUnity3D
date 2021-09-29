using UnityEngine;

class SurveyNeighbors : INeighborsEvent
{
    /// <summary>
    /// Опрасить соседей, узнать нужно ли сдвигать кубы.
    /// </summary>
    public SurveyNeighbors(Direction pDirection)
    {
        Direction = pDirection;
    }

    public bool Survey(Environment pEnviroment)
    {
        bool result = false;

        GameObject obj;

        if (pEnviroment.Neighbors.TryGetValue(Direction, out obj))
        {
            if (obj.CompareTag(HitData.CUBE))
            {
                // Если уперлись в куб, то узнаем во что уперается этот куб.
                if (obj.TryGetComponent(out MBCubeObject aCubeObject))
                    result = aCubeObject.Environment.Event(new SurveyNeighbors(Direction));
            }
        }
        else
            // Если обьект null, значит там пустое место и нужно произвести сдвиг.
            result = true;

        return result;
    }

    public Direction Direction { private set; get; }
}
