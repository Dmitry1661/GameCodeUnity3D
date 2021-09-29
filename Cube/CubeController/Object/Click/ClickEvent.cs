using UnityEngine;

public class ClickEvent
{
    public ClickEvent(MBCubeController pCube)
    {
        // Если Result==TRUE значит нужно либо отправить куб в поле, либо сменить его на другой.
        // Смена куба происходит при уловии что Location.Choise
        // Отправка в поле происходит при уловии что Location.Panel
        if (new TimerControl(pCube).Result)
        {
            // Если мы находимся в Choise, то сменяем куб.
            {
                //new ChangeCube(pCubeController); 
            }

            // Если мы находимся в Panel, то мы отправляем его на поле.
            {
                new SendTheCubeToTheField(pCube);
            }
        }
    }
}
