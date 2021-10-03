using UnityEngine;

class AddOpponent : IUnitEvent
{
    public AddOpponent(string pNameObjectOpponent)
    {
        NameObj = pNameObjectOpponent;
    }

    public void Event(MBUnitController pUnitController)
    {
        if (GameObject.Find(NameObj).TryGetComponent(out MBUnitController aUnitController))
            pUnitController.OpponentManager.Add(aUnitController);
    }

    public string NameObj { private set; get; }
}
