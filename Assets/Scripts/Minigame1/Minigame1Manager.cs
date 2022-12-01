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

    public AudioSource beep;

    private void Update()
    {
        if(cookieCounter == 5 && croissantCounter == 5 && cupcakeCounter == 5 && GameObject.Find("GameManager").GetComponent<GameManager>().minigame1_complete == false)
        {
            StartCoroutine(DisplayText());
            GameObject.Find("GameManager").GetComponent<GameManager>().minigame1_complete = true;
            GameObject.Find("GameManager").GetComponent<GameManager>().level++;
        }
    }

    IEnumerator DisplayText()
    {
        gamePanel.SetActive(true);
        gameText.SetActive(true);
        beep.Play();
        yield return new WaitForSeconds(5);
        Destroy(gameText);
        continueButton.SetActive(true);
        beep.Play();
        GameObject.Find("Minigame1Song").GetComponent<AudioSource>().Pause();
    }

}
