using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InteractionController : MonoBehaviour
{
    [SerializeField]
    private float flySpeed;
    [SerializeField]
    private Camera playerCamera;
    [SerializeField]
    private GameObject rocketText, chairText;
    [SerializeField]
    private Rigidbody rocket;
    [SerializeField]
    private Transform sitPosition;

    private void OnTriggerStay(Collider other)
    {
        CheckIfHovering();
    }

    private void OnTriggerExit(Collider other)
    {
        DisableText(rocketText);
        DisableText(chairText);
    }

    void CheckIfHovering()
    {
        RaycastHit hit;
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.CompareTag("rocket"))
            {
                EnableText(rocketText);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    RocketFly();
                }  
            }
            else if (hit.transform.CompareTag("chair"))
            {
                EnableText(chairText);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    SitOnChair();
                }
            }
        }
        else
        {
            DisableText(rocketText);
            DisableText(chairText);
        }
    }

    void RocketFly()
    {
        rocket.AddForce(transform.up * flySpeed, ForceMode.VelocityChange);
    }

    void SitOnChair()
    {
        Vector3 position = new Vector3(sitPosition.transform.position.x, 1f, sitPosition.transform.position.z);
        Vector3 rotation = new Vector3(.0f, sitPosition.eulerAngles.y - 90f, .0f);

        transform.position = position;
        transform.rotation = Quaternion.Euler(rotation);
    }

    void EnableText(GameObject text)
    {
        text.SetActive(true);
    }

    void DisableText(GameObject text)
    {
        text.SetActive(false);
    }
}
