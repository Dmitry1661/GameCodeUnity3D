using UnityEngine;

public class MBCubeObject : MonoBehaviour
{
    public GameObject GameObj { private set; get; }
    public MBGameSystem GameSystem { private set; get; }
    public MBTransform Transform { private set; get; }
    public MBTimer Timer { private set; get; }

    public void Awake()
    {
        GameObj = gameObject;

        if (GameObject.Find(GameData.GAME_SYSTEM).TryGetComponent(out MBGameSystem aGameSystem))
            GameSystem = aGameSystem;

        if (gameObject.TryGetComponent(out MBTransform aTransform))
            Transform = aTransform;

        if (gameObject.TryGetComponent(out MBTimer aTimer))
            Timer = aTimer;

        Property = new CubeProperty();
        Environment = new Environment(this);
        Maker = new ConnectTheMaker();
    }

    public CubeProperty Property { private set; get; }
    public Environment Environment { private set; get; }
    public ConnectTheMaker Maker { private set; get; }
}


