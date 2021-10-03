using UnityEngine;

/// <summary>
/// Борты.
/// Борты представляют собой обьекты(STOPPED) которые окружают поле(square) тем самым создают границы.
/// По логике кубы не могут покинуть поле физически, но так же и не могут попасть туда из панели(Panel).
/// У каждого из Unit есть прилигающие к нему борты(обьекты STOPEED) один по вертикали и один по горизонтали, 
/// когда происходи отправлка куба из панели на поле мы "поднимаем" борты(а по факрту делалаем их временно 
/// SetActive(false)) что бы кубик ничто не останавливало. После того как куб достигнит противолижащих бортов
/// он обратится к своему "Создателю" и сообщит что бы тот опустил борты.
/// </summary>
public class BoardsManager
{

    /// <summary>
    /// Параметр принимает префикс к обьету Boards.
    /// И в зависимости от префикса будет получена ссылка на обьект отвечающий за борты определеного Unit.
    /// pPrefix + Boards.
    /// </summary>
    /// <param name="pPrefix"></param>
    public BoardsManager(string pPrefix)
    {
        Boards = GameObject.Find(pPrefix + BoardsData.Name);
    }

    /// <summary>
    /// Поднять борты.
    /// </summary>
    public void Raise()
    {
        Boards.SetActive(false);
    }

    /// <summary>
    /// Опустить порты.
    /// </summary>
    public void Down()
    {
        Boards.SetActive(true);
    }

    public GameObject Boards { private set; get; }
}

