using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketScript : MonoBehaviour
{
    public GameObject player;

    [SerializeField]
    private GameObject rocketText;
    /*
    private void OnTriggerStay(Collider other)
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            if(hit.transform.name == "raket")
            {
                print("Hovering over rocket");
            }
        }
    }

    
    void CheckIfHovering()
    {

    }

    private void OnMouseEnter()
    {
        rocketText.SetActive(true);
    }

    private void OnMouseExit()
    {
        rocketText.SetActive(false);
    }
    */
}
