/// <summary>
/// Преобразовываем Direction.
/// </summary>
public class ConversionDirection
{
    /// <summary>
    /// Для того что бы куб отправить в square(поле) нужно выстовить ему правильный Direction.
    /// Если куб создовался у Player1, то для того что бы подняться в нужную позицию в Panel
    /// задается либо Direction.Upper, либо Direction.Left. Для того что бы из позиции Panel 
    /// отправить куб в поле конвертируем Direction.Upper в Direction.Left и куб из правой панели
    /// улетает в левую сторону где и распологается поле.
    /// </summary>
    /// <param name="pDirection"></param>
    public ConversionDirection(MBCubeObject pCube)
    {
        if (new CubePropertyControl(pCube, PropertyControlData.HAS_DIRECTION_FLAG, Direction.Upper).Result)
            Direction = Direction.Left;
        else if (new CubePropertyControl(pCube, PropertyControlData.HAS_DIRECTION_FLAG, Direction.Lower).Result)
            Direction = Direction.Right;
        else if (new CubePropertyControl(pCube, PropertyControlData.HAS_DIRECTION_FLAG, Direction.Left).Result)
            Direction = Direction.Upper;
        else if (new CubePropertyControl(pCube, PropertyControlData.HAS_DIRECTION_FLAG, Direction.Right).Result)
            Direction = Direction.Lower;
    }

    public Direction Direction { private set; get; }
}
