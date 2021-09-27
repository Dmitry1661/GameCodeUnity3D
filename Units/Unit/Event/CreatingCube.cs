using System;
using System.Collections.Generic;
using UnityEngine;

public class CreatingCube : IUnitEvent
{
    public CreatingCube(string pName)
    {
        Name = pName;
    }
    public CreatingCube(string pName, Direction pDirection, Action pAction)
    {
        Name = pName;
        Direction = pDirection;
        Action = pAction;
    }

    public void Event(MBUnitController pUnitController)
    {
        // Создаем куб с помощью GameObject.
        MBCubeObject cubeController =
            pUnitController.CubeManager.Cubes[Name]
            .GetComponent<MBCreation>().Use()
                .GetComponent<MBCubeObject>();

        new TransformControl(cubeController, pUnitController.CubeManager.RespownPosition);
        new PropertyControl(cubeController, PropertyControlData.CREATING_CUBE, Direction);

        // Добавим ссылку на создателя.
        //cubeController.Maker.AddUnit(pUnitController);

        // Определим ссыку на куб Choice создателю.
        //pUnitController.ChoiceManager.Define(cubeController);
    }

    public string Name { private set; get; }
    public Direction Direction { private set; get; }
    public Action Action { private set; get; }
}
