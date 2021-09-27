struct EnvironmentControl
{
    public EnvironmentControl(MBCubeObject pCube, int pCommand)
    {
        Result = false;

        switch (pCommand)
        {
            case EnvironmentControlData.HAS_NEED_SHIFT:
                pCube.Environment.Event(new SurveyNeighbors(pCube.Property.Direction)); 
                break;

            case EnvironmentControlData.MAKE_SHIFT:
                pCube.Environment.Event(new DefinePropertyActionMoveNeighbor(pCube.Property.Direction)); 
                break;
        }
    }

    public bool Result { private set; get; }
}
