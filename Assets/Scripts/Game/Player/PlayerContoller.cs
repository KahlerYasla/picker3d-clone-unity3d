using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private float offset = 3.2f;
    // Start is called before the first frame update
    void Start()
    {
        // get the player object
        player = GameObject.Find("Player");
    }

    void Update()
    {
        // if touching or clicking the screen move the player
        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            MovePlayer();
        }
    }

    void MovePlayer()
    {
        // get the position of the ray collision with the plane tagged as "Heaven"
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity) && hit.collider.gameObject.tag == "Heaven")
        {
            // move the player to the position of the ray collision with the plane tagged as "Heaven"
            player.transform.position = new Vector3(hit.point.x, player.transform.position.y, player.transform.position.z);
        }

        // safe the player position in offset and -offset
        if (player.transform.position.x > offset)
        {
            player.transform.position = new Vector3(offset, player.transform.position.y, player.transform.position.z);
        }
        else if (player.transform.position.x < -offset)
        {
            player.transform.position = new Vector3(-offset, player.transform.position.y, player.transform.position.z);
        }
    }
}
