using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusButton : MonoBehaviour
{
    public GameObject backPanel;
    public GameObject plusPanel;

    [SerializeField]
    private bool isPanelOn;

    private void Start()
    {
        plusPanel.SetActive(false);
        backPanel.SetActive(false);
        isPanelOn = false;
    }

    public void OpenPlusPanel()
    {
        if (!isPanelOn)
        {
            plusPanel.SetActive(true);
            backPanel.SetActive(true);
        }
        else
        {
            plusPanel.SetActive(false);
            backPanel.SetActive(false);
        }

        isPanelOn = !isPanelOn;
    }
}