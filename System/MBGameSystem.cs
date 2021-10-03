using UnityEngine;

public class MBGameSystem : MonoBehaviour
{
    private void Awake()
    {
        Logic = new GameLogic();
        StartCoroutine(Logic.RunningGameProcess());
    }

    public GameLogic Logic { private set; get; }
}

