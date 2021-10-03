public class CubeUpdate
{
    public CubeUpdate(MBCubeObject pCube, float pDeltaTime)
    {
        // Узнаем находиться ли куб в состоянии движения.
        if (new CubePropertyControl(pCube, PropertyControlData.HAS_FLAG_ACTION_MOVE).Result)
        {
            // Если да, то двигаем обьект.
            new CubeTransformControl(pCube, pDeltaTime);

            // Конечный результат жизнидеятельности обьекта.
            new EndResult(pCube);
        }
    }
}
