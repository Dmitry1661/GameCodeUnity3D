using UnityEngine;

public class MBCubeController : MBCubeObject
{
    void Update()
    {
        new CubeUpdate(this, Time.deltaTime);
    }
}


