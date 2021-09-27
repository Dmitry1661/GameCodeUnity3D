using UnityEngine;

struct PropertyControl
{
    public PropertyControl(MBCubeObject pCube, int pCommand, object pObject = null)
    {
        Result = false;

        switch (pCommand)
        {
            case PropertyControlData.HAS_FLAG_ACTION_NONE:
                Result = pCube.Property.Action.HasFlag(Action.None);
                break;

            case PropertyControlData.HAS_FLAG_ACTION_MOVE:
                Result = pCube.Property.Action.HasFlag(Action.Move);
                break;

            case PropertyControlData.SET_FLAG_ACTION_MOVE:

                pCube.Property.Define(Action.Move);
                if (pObject != null && pObject is Direction)
                    pCube.Property.Define((Direction)pObject);

                break;

            case PropertyControlData.SET_FLAG_ACTION_NONE:
                pCube.Property.Define(Action.None);

                if (pObject != null && pObject is Vector3)
                    pCube.Transform.NextPosition((Vector3)pObject);
                break;

            case PropertyControlData.HAS_DIRECTION_FLAG:
                if (pObject != null && pObject is Direction) 
                    Result = pCube.Property.Direction.HasFlag((Direction)pObject);
                break;

            case PropertyControlData.CREATING_CUBE:
                if (pObject != null && pObject is Direction)
                    pCube.Property.Define(Action.Move, Location.Choice, (Direction)pObject);
                break;
        }
    }

    public bool Result { private set; get; }
}
