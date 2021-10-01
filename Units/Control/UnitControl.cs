
public class UnitControl
{
    public UnitControl(MBUnitController pUnit, MBCubeObject pCube, int pCommand)
    {
        switch (pCommand)
        {
            case UnitControlData.ADD_LINK_THE_CHOICE:
                pUnit.ChoiceManager.Define(pCube);
                break;
        }
    }

    public UnitControl(MBCubeObject pCube, int pCommand)
    {
        switch (pCommand)
        {
            case UnitControlData.BOARDS_RAISE:
                pCube.Unit.UnitController.BoardsManager.Raise();
                break;

            case UnitControlData.BOARDS_DOWN:
                pCube.Unit.UnitController.BoardsManager.Down();
                break;
        }
    }

    public UnitControl(string pName, MBUnitController pUnit, int pCommand, object pObject)
    {
        switch (pCommand)
        {
            case UnitControlData.CREATING_CUBE:
                if (pObject != null && pObject is Direction)
                    pUnit.Event(new CreatingCube(pName, (Direction)pObject, Action.Move));
                break;
        }
    }

    public UnitControl(string pName, MBUnitController pUnit, int pCommand, object[] pObjectArray)
    {
        switch (pCommand)
        {
            case UnitControlData.TO_CONFIG_CUBE_MANAGER:
                if (pObjectArray != null && pObjectArray is string[])
                    pUnit.Event(new ToConfigCubeManager(pName, (string[])pObjectArray));
                break;

        }
    }
}
