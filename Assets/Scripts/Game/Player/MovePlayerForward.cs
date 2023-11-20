using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerForward : MonoBehaviour
{
    public GameObject player;
    public bool movePlayer = false;

    // Update is called once per frame
    void Update()
    {
        // move the player forward
        if (movePlayer) player.transform.position += Vector3.forward * Time.deltaTime * 7;
    }
}
