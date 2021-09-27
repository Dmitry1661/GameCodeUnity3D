using System.Collections.Generic;
using UnityEngine;

public class MBCubeManager : MonoBehaviour
{
    private void Awake()
    {
        Cubes = new Dictionary<string, GameObject>();
    }

    /// <summary>
    /// Получаем стартовую позицию для кубов.
    /// </summary>
    /// <param name="pObjectNamePositionRespown">Имя обьекта, у которого будет взята позиция и присвоина обьекту.</param>
    public void AddRespownPosition(string pObjectNamePositionRespown)
    {
        if (GameObject.Find(pObjectNamePositionRespown).TryGetComponent(out Transform aTransform))
            RespownPosition = aTransform.position;
    }

    /// <summary>
    /// Записываем в Dictionary GameObject префаба.
    /// </summary>
    /// <param name="pName">Имя куба.</param>
    /// <param name="pPath">Путь до префаба куба.</param>
    public void AddCube(string pName, string pPath)
    {
        Cubes.Add(pName, Resources.Load(pPath) as GameObject);
    }

    public Vector3 RespownPosition { private set; get; }
    public Dictionary<string, GameObject> Cubes { private set; get; }
}
