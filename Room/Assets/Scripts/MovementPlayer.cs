using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller;
    [SerializeField]
    private float speed = 10f;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
}
