using UnityEngine;

public class MBPanel : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out MBCubeObject obj))
            new PropertyControl(obj, PropertyControlData.SET_LOCATION_PANEL);
    }
}

