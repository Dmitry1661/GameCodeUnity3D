struct MakerControlData
{
    /// <summary>
    /// Добавить ссылку на создатя в куб.
    /// </summary>
    public const int ADD_MAKER = 0;
}

class MakerControl
{
    public MakerControl(MBUnitController pUnit, MBCubeObject pCube, int pCommand)
    {
        switch(pCommand)
        {
            case MakerControlData.ADD_MAKER:
                pCube.Unit.AddUnit(pUnit);
                break;
        }
    }
}
