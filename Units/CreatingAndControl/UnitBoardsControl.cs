using UnityEngine;

class UnitBoardsControl
{
    public UnitBoardsControl(MBCubeObject pCube, int pCommand)
    {
        switch (pCommand)
        {
            case BoardsControlData.BOARDS_RAISE:
                pCube.Unit.UnitController.BoardsManager.Raise();
                break;

            case BoardsControlData.BOARDS_DOWN:
                Debug.Log(11);
                pCube.Unit.UnitController.BoardsManager.Down();
                break;
        }
    }
}
