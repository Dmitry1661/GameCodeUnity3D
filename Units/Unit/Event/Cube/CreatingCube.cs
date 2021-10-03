public class CreatingCube : IUnitEvent
{
    public CreatingCube(string pName)
    {
        Name = pName;
    }
    public CreatingCube(string pName, Direction pDirection, Action pAction)
    {
        Name = pName;
        Direction = pDirection;
        Action = pAction;
    }

    public void Event(MBUnitController pUnit)
    {
        // Создаем куб с помощью GameObject.
        MBCubeObject cube =
            pUnit.CubeManager.Cubes[Name]
            .GetComponent<MBCreation>().Use()
                .GetComponent<MBCubeObject>();

        new CubeTransformControl(cube, pUnit.CubeManager.RespownPosition);
        new CubePropertyControl(cube, PropertyControlData.CREATING_CUBE, Direction);
        new CubeCurrentUnitControl(pUnit, cube, CurrentUnitControlData.SET_CURRENT_UNIT);

        new UnitChoiceControl(pUnit, cube, ChoiceControlData.ADD_LINK_THE_CHOICE);
    }

    public string Name { private set; get; }
    public Direction Direction { private set; get; }
    public Action Action { private set; get; }
}
