using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject cameraBlueArm;
    // Start is called before the first frame update
    void Start()
    {
        cameraBlueArm = GameObject.Find("CameraBlueArm");
    }

    // Update is called once per frame
    void Update()
    {
        // follow the player all axis except x axis
        transform.position = new Vector3(transform.position.x, cameraBlueArm.transform.position.y, cameraBlueArm.transform.position.z);
    }
}
