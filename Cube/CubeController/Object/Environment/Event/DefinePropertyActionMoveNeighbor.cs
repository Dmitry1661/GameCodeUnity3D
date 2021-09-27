using UnityEngine;

public class DefinePropertyActionMoveNeighbor : INeighborsEvent
{
    public DefinePropertyActionMoveNeighbor(Direction pDirection)
    {
        Direction = pDirection;
    }

    public bool Survey(Environment pEnvironment)
    {
        bool result = false;

        GameObject obj = null;

        if (pEnvironment.Neighbors.TryGetValue(Direction, out obj))
        {
            // Проходим по всем кубам в задоном направлении и выставляем Action.Move.
            if (obj.CompareTag(HitData.CUBE))
            {
                new PropertyControl(pEnvironment.Cube, PropertyControlData.SET_FLAG_ACTION_MOVE, Direction);

                if (obj.TryGetComponent(out MBCubeObject aCubeObject))
                    aCubeObject.Environment.Event(new DefinePropertyActionMoveNeighbor(Direction));
                else
                {
                    // Если упераемся не в Cube.
                    result = true;
                }
            }
        }

        return result;
    }

    public Direction Direction { private set; get; }
}
