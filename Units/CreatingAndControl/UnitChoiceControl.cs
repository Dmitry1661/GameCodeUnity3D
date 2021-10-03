class UnitChoiceControl
{
    public UnitChoiceControl(MBUnitController pUnit, MBCubeObject pCube, int pCommand)
    {
        switch (pCommand)
        {
            case ChoiceControlData.ADD_LINK_THE_CHOICE:
                pUnit.ChoiceManager.Define(pCube);
                break;
        }
    }
}
