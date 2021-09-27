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
                    aCubeObject.Environment.Event(new SurveyNeighbors(Direction));
            }
            else if (obj.CompareTag(HitData.STOPPED))
            {
                // Если упераемся  в обьект Stopped, то ничего не делаем.
            }
            else
            {
                // Если не во что не упираемся, то сдвигаем.
                result = true;
            }
        }

        return result;
    }

    public Direction Direction { private set; get; }
}
