using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_Text messageText;
    public GameObject messagePanel;
    private float displayTimer = 3f;
    private float displayLength = 3f;
    private bool isShowingMessage = false;
    
    public void ShowMessage(string message, float duration)
    {
        messagePanel.SetActive(true);
        messageText.text = message;
        isShowingMessage = true;
        displayLength = duration;
        displayTimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(isShowingMessage)
        {
            if(Time.time - displayTimer > displayLength)
            {
                messagePanel.SetActive(false);
                isShowingMessage = false;
            }
        }
    }
}
