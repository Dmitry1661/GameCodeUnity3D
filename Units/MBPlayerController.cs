public class MBPlayerController : MBUnitController
{
    public void Start()
    {
        Creating.Run(this, PlayerData.PLAYER_1, 
            PlayerData.PLAYER_1_DIRECTION_HORIZONTAL, PlayerData.PLAYER_1_DIRECTION_VERTICAL,
            PlayerData.PLAYER_2, true);
    }
}
