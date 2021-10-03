using UnityEngine;

public class MBPanel : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out MBCubeObject obj))
            new CubePropertyControl(obj, PropertyControlData.SET_LOCATION_PANEL);
    }
}

