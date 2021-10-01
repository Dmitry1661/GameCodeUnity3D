using UnityEngine;

public class MBEnemyController : MBUnitController
{
    public void Start()
    {
        Creating.Run(this, PlayerData.PLAYER_2, 
            PlayerData.PLAYER_2_DIRECTION_HORIZONTAL, PlayerData.PLAYER_2_DIRECTION_VERTICAL,
            PlayerData.PLAYER_1, false);
    }
}
