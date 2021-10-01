using UnityEngine;

public class MBUnitController : MonoBehaviour
{
    public MBGameSystem GameSystem { private set; get; }
    public MBCubeManager CubeManager { private set; get; }
    public MBCreatingUnit Creating { private set; get; }

    public void Awake()
    {
        if (GameObject.Find(GameData.GAME_SYSTEM).TryGetComponent(out MBGameSystem aGameSystem))
            GameSystem = aGameSystem;

        if (GameObject.Find(GameData.GAME_SYSTEM).TryGetComponent(out MBCreatingUnit aCreatingUnit))
            Creating = aCreatingUnit;

        if (gameObject.TryGetComponent(out MBCubeManager aCubeManager))
            CubeManager = aCubeManager;

        BoardsManager = new BoardsManager(gameObject.name);
        ChoiceManager = new ChoiceManager();
    }

    public void Event(IUnitEvent pUnitEvent)
    {
        pUnitEvent.Event(this);
    }

    public BoardsManager BoardsManager { private set; get; }
    public ChoiceManager ChoiceManager { private set; get; }
}

