using UnityEngine;

public class Uncouple : MonoBehaviour
{
    private HingeJoint2D _hingeJoint;

    private void Start()
    {
        _hingeJoint = GetComponent<HingeJoint2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _hingeJoint.connectedBody = null;
            _hingeJoint.enabled = false;
        }
    }
}
