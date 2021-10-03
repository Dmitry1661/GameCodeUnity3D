using UnityEngine;

class UnitStateControl
{
    public UnitStateControl(MBUnitController pUnit, int pCommand, object[] pObjectArray = null)
    {
        switch (pCommand)
        {
            case UnitStateControlData.INITIALIZE:
                if (pObjectArray[0] is bool && pObjectArray[1] is int && pObjectArray[2] is int)
                    pUnit.Event(new InitializeStateManager((bool)pObjectArray[0], (int)pObjectArray[1], (int)pObjectArray[2]));
                break;
        }
    }

    public UnitStateControl(MBCubeObject pCube, int pCommand, object pObject = null)
    {
        MBUnitController unit = pCube.Unit.UnitController;

        // Если StateManager не инициализирован значит нам нечего там делать.
        if (!unit.StateManager.IsInitilize) return;

        switch (pCommand)
        {
            case UnitStateControlData.HAS_RUNNING:
                Result = unit.StateManager.StateRunning.Running;
                break;

            case UnitStateControlData.INCREMENT_MOTION:
                unit.Event(new IncrementMotion());
                break;
        }
    }

    public bool Result { private set; get; }
}
