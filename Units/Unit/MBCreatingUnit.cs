﻿using System.Collections;
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
            CreatingUnitCoroutine( pUnitController, pUnitName, pDirectionHorizontal, 
                pDirectionVertical, pUnitEnemyName, pFirstRun)
            );
    }

    private IEnumerator CreatingUnitCoroutine(MBUnitController pUnit, string pUnitName,
        Direction pDirectionHorizontal, Direction pDirectionVertical, string pUnitEnemyName, bool pFirstRun)
    {
        // Добавим нашего Unit в игровую логику.
        new GameControl(pUnit, GameControlData.ADD_UNIT, pFirstRun);

        new UnitControl(pUnitName, pUnit, UnitControlData.TO_CONFIG_CUBE_MANAGER, new string[] { CubeData.DEFAULT_CUBE_NAME });

        // Создадим кубы по горизонатали.
        for (int i = 0; i < PanelData.HORIZONTAL_COUNT; i++)
        {
            new UnitControl(CubeData.DEFAULT_CUBE_NAME, pUnit, UnitControlData.CREATING_CUBE, pDirectionHorizontal);

            yield return new WaitForSeconds(CubeData.TIME_STEP_CREATING_CUBE);
        }

        // Создадим кубы по горизонатали.
        for (int i = 0; i < PanelData.VERTICAL_COUNT; i++)
        {
            new UnitControl(CubeData.DEFAULT_CUBE_NAME, pUnit, UnitControlData.CREATING_CUBE, pDirectionVertical);

            yield return new WaitForSeconds(CubeData.TIME_STEP_CREATING_CUBE);
        }

        new UnitControl(CubeData.DEFAULT_CUBE_NAME, pUnit, UnitControlData.CREATING_CUBE, Direction.None);

        yield return null;
    }
}
