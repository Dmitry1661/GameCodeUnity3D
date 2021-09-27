public class CubeUpdate
{
    public CubeUpdate(MBCubeObject pCubeController, float pDeltaTime)
    {
        // Узнаем находиться ли куб в состоянии движения.
        if (new PropertyControl(pCubeController, PropertyControlData.HAS_FLAG_ACTION_MOVE).Result)
            // Если да, то двигаем обьект.
            new TransformControl(pCubeController, pDeltaTime);

        // Конечный результат жизнидеятельности обьекта.
        new EndResult(pCubeController);
    }
}
