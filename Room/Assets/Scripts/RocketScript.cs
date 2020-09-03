using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketScript : MonoBehaviour
{
    public GameObject player;

    [SerializeField]
    private GameObject rocketText;
    [SerializeField]
    private float distance;

    private void Update()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);
    }

    private void OnMouseEnter()
    {
        rocketText.SetActive(true);
    }

    private void OnMouseExit()
    {
        rocketText.SetActive(false);
    }
}
