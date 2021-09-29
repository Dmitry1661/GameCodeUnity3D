using System.Collections;
using UnityEngine;

public class MBCreatingUnit : MonoBehaviour
{
    public MBGameSystem GameSystem { private set; get; }

    void Awake()
    {
        if (GameObject.Find(GameData.GAME_SYSTEM).TryGetComponent(out MBGameSystem aGameSystem))
            GameSystem = aGameSystem;
    }

    public void Run(MBUnitController pUnitController, string pUnitName,
        Direction pDirectionHorizontal, Direction pDirectionVertical, string pUnitEnemyName, bool pFirstRun)
    {
        StartCoroutine(
            CreatingUnitCoroutine(
                pUnitController,
                pUnitName,
                pDirectionHorizontal, pDirectionVertical,
                pUnitEnemyName,
                pFirstRun)
            );
    }
    private IEnumerator CreatingUnitCoroutine(MBUnitController pUnitController, string pUnitName,
        Direction pDirectionHorizontal, Direction pDirectionVertical, string pUnitEnemyName, bool pFirstRun)
    {
        // Запишим место респауна кубов.
        pUnitController.CubeManager
            .AddRespownPosition(pUnitName + PlayerData.PLAYER_RESPOWN);

        // Запишим все кубы которые мы можем использовать.
        pUnitController.CubeManager
            .AddCube(CubeData.DEFAULT_CUBE_NAME, CubeData.DEFAULT_CUBE_PATH);

        // Создадим кубы по горизонатали.
        for (int i = 0; i < PanelData.HORIZONTAL_COUNT; i++)
        {
            pUnitController.Event(new CreatingCube(CubeData.DEFAULT_CUBE_NAME, pDirectionHorizontal, Action.Move));

            yield return new WaitForSeconds(CubeData.TIME_STEP_CREATING_CUBE);
        }

        yield return null;
    }
}
