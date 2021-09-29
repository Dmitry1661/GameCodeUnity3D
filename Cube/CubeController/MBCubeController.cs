using UnityEngine;
using UnityEngine.EventSystems;

public class MBCubeController : MBCubeObject, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        new ClickEvent(this); 
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        new ClickEvent(this); 
    }

    void Update()
    {
        new CubeUpdate(this, Time.deltaTime);
    }
}


