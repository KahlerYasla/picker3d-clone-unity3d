using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragToStartPanelManager : MonoBehaviour
{
    private GameObject panel;
    // if any drag is detected, hide the panel and start the game
    void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            panel = GameObject.Find("DragToStartPanel");
            panel.SetActive(false);

            GameObject.Find("MovePlayerForward").GetComponent<MovePlayerForward>().movePlayer = true;
            GameObject.Find("PanelsController").GetComponent<PanelsController>().ShowPanel("GamePlayPanel");

            GameObject gamePlayPanel = GameObject.Find("GamePlayPanel");

            GameObject previousLevel = gamePlayPanel.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject;
            GameObject nextLevel = gamePlayPanel.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject;

            previousLevel.GetComponent<TMPro.TextMeshProUGUI>().text = (PlayerPrefs.GetInt("Level") + 1).ToString();
            nextLevel.GetComponent<TMPro.TextMeshProUGUI>().text = (PlayerPrefs.GetInt("Level") + 2).ToString();

            // disable this script
            this.enabled = false;
        }
    }
}
