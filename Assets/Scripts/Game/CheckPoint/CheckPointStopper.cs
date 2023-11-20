using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointStopper : MonoBehaviour
{
    private bool _isTriggered = false;

    // if the player collides with the checkPointStopper, stop the player
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_isTriggered)
        {
            GameObject.Find("MovePlayerForward").GetComponent<MovePlayerForward>().movePlayer = false;

            other.gameObject.GetComponent<ThrowTheBalls>().isThrow = true;

            Invoke("SetThrowBallsFalse", 1f);

            _isTriggered = true;
        }
    }

    private void SetThrowBallsFalse()
    {
        GameObject.Find("Player").GetComponent<ThrowTheBalls>().isThrow = false;
    }
}
