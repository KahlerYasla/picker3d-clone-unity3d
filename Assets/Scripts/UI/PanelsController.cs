using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelsController : MonoBehaviour
{
    public GameObject[] panels;

    public void ShowPanel(string panelName)
    {
        foreach (GameObject panel in panels)
        {
            if (panel.name == panelName)
            {
                panel.SetActive(true);
            }
            else
            {
                panel.SetActive(false);
            }
        }
    }
}
