class UnitCubeControl
{
    public UnitCubeControl(string pName, MBUnitController pUnit, int pCommand, object pObject)
    {
        switch (pCommand)
        {
            case UnitCubeControlData.CREATING_CUBE:
                if (pObject != null && pObject is Direction)
                    pUnit.Event(new CreatingCube(pName, (Direction)pObject, Action.Move));
                break;
        }
    }

    public UnitCubeControl(string pName, MBCubeObject pCube, int pCommand, object pObject)
    {
        switch (pCommand)
        {
            case UnitCubeControlData.CREATING_CUBE:
                if (pObject != null && pObject is Direction)
                    pCube.Unit.UnitController.Event(new CreatingCube(pName, (Direction)pObject, Action.Move));
                break;
        }
    }

    public UnitCubeControl(string pName, MBUnitController pUnit, int pCommand, object[] pObjectArray)
    {
        switch (pCommand)
        {
            case UnitCubeControlData.TO_CONFIG_CUBE_MANAGER:
                if (pObjectArray != null && pObjectArray is string[])
                    pUnit.Event(new ToConfigCubeManager(pName, (string[])pObjectArray));
                break;

        }
    }
}
