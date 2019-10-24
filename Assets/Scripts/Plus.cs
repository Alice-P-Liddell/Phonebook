using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus : MonoBehaviour
{
    public GameObject plusPanel;
    public GameObject backPanel;

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
