using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusButton : MonoBehaviour
{
    public GameObject addPanel;
    public InputField nameInputField;

    [SerializeField]
    private bool isPanelOn;

    private void Start()
    {
        isPanelOn = false;
        addPanel.SetActive(false);
        nameInputField.text = null;
    }

    public void OpenPlusPanel()
    {
        if (!isPanelOn)
        {
            addPanel.SetActive(true);
            //StartCoroutine("PanelAnim");
        }
        else
        {
            //StartCoroutine("PanelAnim");
            addPanel.SetActive(false);
            nameInputField.text = null;
        }

        isPanelOn = !isPanelOn;
    }

    /*
    IEnumerator PanelAnim()
    {
        while (addPanel.transform.position.y < 0)
        {
            addPanel.transform.Translate(Vector2.up * 2, Space.Self);

        }
        yield return null;
    }
    */
}