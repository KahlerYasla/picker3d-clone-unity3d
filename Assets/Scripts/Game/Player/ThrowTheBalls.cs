using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowTheBalls : MonoBehaviour
{
    public bool isThrow = false;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Collectable" && isThrow)
        {
            Vector3 initialPosition = other.gameObject.transform.position;
            Vector3 finalPosition = initialPosition + new Vector3(0, 0, 4);

            // transform translate the Collectable to the player to throw away
            other.gameObject.transform.position = Vector3.Lerp(initialPosition, finalPosition, 3f);
        }
    }
}
