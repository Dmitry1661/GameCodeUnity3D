class CubeCurrentUnitControl
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="pUnit"></param>
    /// <param name="pCube"></param>
    /// <param name="pCommand"></param>
    public CubeCurrentUnitControl(MBUnitController pUnit, MBCubeObject pCube, int pCommand)
    {
        switch(pCommand)
        {
            case CurrentUnitControlData.SET_CURRENT_UNIT:
                pCube.Unit.SetUnit(pUnit);
                break;
        }
    }
}
