using UnityEngine;

public class Fastening : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out HingeJoint2D hingeJoint2D))
        {
            hingeJoint2D.enabled = true;
            hingeJoint2D.connectedBody = _rigidbody;
        }
    }
}
