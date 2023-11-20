using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{

    // if the player collides with the finishLine, stop the player
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("MovePlayerForward").GetComponent<MovePlayerForward>().movePlayer = false;

            GameObject.Find("PanelsController").GetComponent<PanelsController>().ShowPanel("WinPanel");
        }

    }

}