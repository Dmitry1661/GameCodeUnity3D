using UnityEngine;
using System.Collections;

public class GameLogic
{
    public GameLogic()
    {
        StateManager = new GameStateManager();
    }

    public IEnumerator RunningGameProcess()
    {
        yield return new WaitForSeconds(2.0f);

        StateManager.SetState(GameState.PlayerMoving);

        yield return null;
    }

    public GameStateManager StateManager { private set; get; }
}

public struct GameLogicControlData
{
    /// <summary>
    /// Проверить ход игрока.
    /// </summary>
    public const int HAS_PLAYER_MOVING = 0;

    /// <summary>
    /// Назначить ход игрока.
    /// </summary>
    public const int SET_PLAYER_MOVING = 1;
}

public class GameLogicControl
{
    public GameLogicControl(MBCubeObject pCube, int pCommand)
    {
        GameLogic logic = pCube.GameSystem.Logic;

        switch (pCommand)
        {
            case GameLogicControlData.SET_PLAYER_MOVING:
                logic.StateManager.SetState(GameState.PlayerMoving);
                break;

            case GameLogicControlData.HAS_PLAYER_MOVING:
                Result = logic.StateManager.GameState.HasFlag(GameState.PlayerMoving);
                break;
        }
    }
    public bool Result { private set; get; }
}

public enum GameState : short
{
    None = 0,
    // Создание уровня.
    CreatingLevel = 4,
    // Ход игрока.
    PlayerMoving = 8,
    // Ожидание хода игрока.
    PlayerWaitMoving = 12 
}

public class GameStateManager
{
    public GameStateManager()
    {
        GameState = GameState.CreatingLevel;
    }

    public void SetState(GameState pGameState)
    {
        GameState = pGameState;
    }

    public GameState GameState { private set; get; }
}
