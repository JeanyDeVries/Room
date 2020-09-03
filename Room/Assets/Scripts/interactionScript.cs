using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionScript : MonoBehaviour
{
    [SerializeField] private GameObject interactionUI;
    [SerializeField] private Transform sittingPoint;

    private bool isInField, isGoingToSit, isSitting;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && isInField && !isGoingToSit)
        {
            isGoingToSit = true;
        }

        if(isGoingToSit)
        {
            player.transform.position = sittingPoint.transform.position;
            interactionUI.SetActive(false);

            isGoingToSit = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            interactionUI.SetActive(true);
            isInField = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        interactionUI.SetActive(false);
        isInField = false;
    }
}
