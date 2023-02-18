using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(1f, 5f)]
    [SerializeField] private float _force;
    [SerializeField] private Rigidbody2D _rigidbody;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            _rigidbody.AddForce(Vector2.left * _force, ForceMode2D.Impulse);

        if (Input.GetKeyDown(KeyCode.D))
            _rigidbody.AddForce(Vector2.right * _force, ForceMode2D.Impulse);
    }
}
