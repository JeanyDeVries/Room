using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    private Rigidbody M_rigidbody;

    private void Start()
    {
        M_rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            M_rigidbody.velocity = transform.forward * movementSpeed;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            M_rigidbody.velocity = -transform.forward * movementSpeed;
        }
    }
}
