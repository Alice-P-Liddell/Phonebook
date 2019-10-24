using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus : MonoBehaviour
{
    public GameObject plusPanel;
    [SerializeField]
    private bool isPanelOn;

    private void Start()
    {
        plusPanel.SetActive(false);
        isPanelOn = false;
    }

    public void OpenPlusPanel()
    {
        if (!isPanelOn)
        {
            plusPanel.SetActive(true);
        }
        else
        {
            plusPanel.SetActive(false);
        }

        isPanelOn = !isPanelOn;
    }
}
