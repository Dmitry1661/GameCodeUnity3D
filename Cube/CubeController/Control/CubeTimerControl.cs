class CubeTimerControl
{
    /// <summary>
    /// Если вернет TRUE значит это простое нажатие, иначе пользователь желает узнать инфорнмаию об кубе.
    /// </summary>
    /// <param name="pCubeController"></param>
    public CubeTimerControl(MBCubeController pCubeController)
    {
        // Если Timer.IsRun == false значит таймер нужно запустить.
        if (!pCubeController.Timer.IsRun)
        {
            pCubeController.Timer.Run();
        }
        // Если Timer.IsRun == true, значит таймер уже запущен.
        else if (pCubeController.Timer.IsRun)
        {
            // Узначем рамер временого шага между DownCick и UpClick, и производим логическое сравнение.
            if (pCubeController.Timer.Step() <= CubeData.TIME_STEP_CLICK_MOVE)
                Result = true; // Если временой шаг короткий, значит запускаем куб в поле.
            else
                Result = false; // Если временой шаг длиный, значит выводим информацию о кубе.
        }

    }

    public bool Result { private set; get; }
}
