using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InteractionController : MonoBehaviour
{
    public float flySpeed;

    [SerializeField]
    private Camera playerCamera;
    [SerializeField]
    private GameObject rocketText, chairText, cactusPrefab;
    [SerializeField]
    private Rigidbody rocket;

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
                    SitOnChair(hit.transform);
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

    void SitOnChair(Transform sitLocation)
    {
        Vector3 sitPosition = sitLocation.position;

        transform.position = new Vector3(sitPosition.x, sitPosition.y, sitPosition.z);
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
