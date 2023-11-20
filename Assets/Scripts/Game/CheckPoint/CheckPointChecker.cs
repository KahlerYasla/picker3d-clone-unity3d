using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointChecker : MonoBehaviour
{
    // TMPro 3d on 3d game object
    public GameObject scoreText;
    public GameObject checkPoint;
    private bool isTriggerCalled = false;

    // increase scoreText by 1 every collision detected on checkPointFloor
    private void OnTriggerEnter(Collider other)
    {
        // collision between Collectables and checkPointFloor

        if (other.gameObject.tag == "Collectable")
        {
            // start particle system on Collectable and then destroy it
            other.gameObject.GetComponent<ParticleSystem>().Play();

            Destroy(other.gameObject, 1f);

            if (scoreText.GetComponent<TextMesh>().text != "6 / 6")
            {
                // increase scoreText by 1 currently the format is 0 / 6
                scoreText.GetComponent<TextMesh>().text = (int.Parse(scoreText.GetComponent<TextMesh>().text[0].ToString()) + 1).ToString() + " / 6";
            }

            if (!isTriggerCalled)
                Invoke("Evaluate", 1f);

            isTriggerCalled = true;
        }
    }

    void Evaluate()
    {
        // if scoreText is 6 or more, load the next level
        if (int.Parse(scoreText.GetComponent<TextMesh>().text[0].ToString()) >= 6)
        {
            Debug.Log("Next Floor");

            // animate the to open
            checkPoint.GetComponent<Animator>().SetTrigger("Elevate");

            // after 2 seconds, move again the player
            Invoke("MovePlayer", 1f);
        }
        else // if scoreText is less than 6
        {
            Debug.Log("Game Over");

            GameObject.Find("MovePlayerForward").GetComponent<MovePlayerForward>().movePlayer = false;

            // Set active the GameOverPanel
            GameObject.Find("PanelsController").GetComponent<PanelsController>().ShowPanel("GameOverPanel");
        }

        // disable this script
        this.enabled = false;
    }

    void MovePlayer()
    {
        GameObject.Find("MovePlayerForward").GetComponent<MovePlayerForward>().movePlayer = true;
    }
}


