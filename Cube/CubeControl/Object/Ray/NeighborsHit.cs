using System;
using System.Collections.Generic;
using UnityEngine;

class NeighborsHit
{
    /// <summary>
    /// Получим все соседние обьекты.
    /// </summary>
    /// <param name="pCubeObject"></param>
    /// <param name="pRays"></param>
    public NeighborsHit(MBCubeObject pCubeObject, Dictionary<Direction, Ray> pRays)
    {
        Neighbors = new Dictionary<Direction, GameObject>();

        foreach (KeyValuePair<Direction, Ray> ray in pRays)
        {
            Vector3 position = pCubeObject.Transform.Position;

            RaycastHit[] hits = Physics.RaycastAll(ray.Value);

            foreach (RaycastHit hit in hits)
            {
                float distance = Vector3.
                    Distance(
                        hit.collider.GetComponent<Transform>().position,
                        position
                    );

                if (distance <= CubeData.HIT_DISTANCE)
                {
                    if (hit.collider.CompareTag(HitData.CUBE) || hit.collider.CompareTag(HitData.STOPPED))
                    {
                        Neighbors[ray.Key] = hit.collider.gameObject;
                    }
                }
            }
        }
    }

    public Dictionary<Direction, GameObject> Neighbors { private set; get; }
}
