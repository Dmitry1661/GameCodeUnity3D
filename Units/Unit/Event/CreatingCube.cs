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

        new TransformControl(cube, pUnit.CubeManager.RespownPosition);
        new PropertyControl(cube, PropertyControlData.CREATING_CUBE, Direction);
        new MakerControl(pUnit, cube, MakerControlData.ADD_MAKER);
        new UnitControl(pUnit, cube, UnitControlData.ADD_LINK_THE_CHOICE);
    }

    public string Name { private set; get; }
    public Direction Direction { private set; get; }
    public Action Action { private set; get; }
}
