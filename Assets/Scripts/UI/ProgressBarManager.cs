using System.Collections;
using UnityEngine;
using UnityEngine.UI; // Add this line to use the UI namespace

public class ProgressBarManager : MonoBehaviour
{
    public GameObject progressBar; // it is a slider
    public GameObject player;
    private GameObject finishLine;

    private float totalDistance = 0;

    void Start()
    {
        Invoke("Init", 1f);
    }

    private IEnumerator Tick() // Fix the capitalization of IEnumerator
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);

            // calculate the distance between the player and the finishLine
            float distance = totalDistance - Vector3.Distance(player.transform.position, finishLine.transform.position);

            // calculate the percentage of the distance
            float percentage = distance / totalDistance * 100;

            Debug.Log("percentage: " + percentage);

            // set the value of the slider
            progressBar.GetComponent<Slider>().value = percentage;
        }
    }

    private void Init()
    {
        // get the finishLine
        finishLine = GameObject.Find("FinishLine");

        // set the value of the slider to 0
        progressBar.GetComponent<Slider>().value = 0;

        // calculate the total distance between the player and the finishLine
        totalDistance = Vector3.Distance(player.transform.position, finishLine.transform.position);

        StartCoroutine(Tick()); // Start the Tick coroutine
    }
}
