using UnityEngine;

public class DefinePropertyActionMoveNeighbor : INeighborsEvent
{
    /// <summary>
    /// Вернет true если уперлись в Cube.
    /// </summary>
    /// <param name="pDirection"></param>
    public DefinePropertyActionMoveNeighbor(Direction pDirection)
    {
        Direction = pDirection;
    }

    public bool Survey(Environment pEnvironment)
    {
        bool result = false;

        new PropertyControl(pEnvironment.Cube, PropertyControlData.SET_FLAG_ACTION_MOVE, Direction);

        GameObject obj;
        if (pEnvironment.Neighbors.TryGetValue(Direction, out obj))
        {
            // Проходим по всем кубам в задоном направлении и выставляем Action.Move.
            if (obj.CompareTag(HitData.CUBE))
            {
                if (obj.TryGetComponent(out MBCubeObject aCubeObject))
                    aCubeObject.Environment.Event(new DefinePropertyActionMoveNeighbor(Direction));

                result = true;
            }
        }

        return result;
    }

    public Direction Direction { private set; get; }
}
