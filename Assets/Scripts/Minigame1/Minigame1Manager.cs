using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Minigame1Manager : MonoBehaviour
{
    public int cookieCounter = 0;
    public int croissantCounter = 0;
    public int cupcakeCounter = 0;

    public GameObject continueButton;
    public GameObject gameText;
    public GameObject gamePanel;

    private void Update()
    {
        //these numbers will be increased later
        if(cookieCounter == 1 && croissantCounter == 1 && cupcakeCounter == 1 && GameObject.Find("GameManager").GetComponent<GameManager>().minigame1_complete == false)
        {
            StartCoroutine(DisplayText());
            GameObject.Find("GameManager").GetComponent<GameManager>().minigame1_complete = true;
        }
    }

    IEnumerator DisplayText()
    {
        gamePanel.SetActive(true);
        gameText.SetActive(true);
        yield return new WaitForSeconds(5);
        Destroy(gameText);
        continueButton.SetActive(true);
    }

}
