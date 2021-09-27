using UnityEngine;

public class MBTransform : MonoBehaviour
{
    public void NextPosition(Vector3 pNextPosition)
    {
        Transform.position = Position = pNextPosition;
    }

    private void Awake()
    {
        RigidBody = gameObject.GetComponent<Rigidbody>();

        Transform = RigidBody.transform;
    }

    public Vector3 Position { private set; get; }
    public Transform Transform { private set; get; }
    public Rigidbody RigidBody { private set; get; }
}
