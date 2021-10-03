using UnityEngine;

/// <summary>
/// Обрабатывает косание обьекта STOPPED.
/// </summary>
class HitStopped
{
    public HitStopped(MBCubeObject pCube, Vector3 pHitPosition)
    {
        new UnitBoardsControl(pCube, BoardsControlData.BOARDS_DOWN);

        new CubePropertyControl(pCube, PropertyControlData.SET_FLAG_ACTION_NONE, pHitPosition);

        //pCube.Unit.UnitController.ChoiceManager.Cube.Property.Define(Action.Move);
        //pCube.Unit.UnitController.ChoiceManager.Cube.Property.Define(new ConversionDirection(pCube).Direction);

        /*
        if (new GameLogicControl(pCube, GameLogicControlData.HAS_PLAYER_MOVING).Result)
            new UnitCubeControl(CubeData.DEFAULT_CUBE_NAME, pCube, UnitCubeControlData.CREATING_CUBE, Direction.None);
        */
    }
}

