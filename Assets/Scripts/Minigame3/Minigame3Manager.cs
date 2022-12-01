using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame3Manager : MonoBehaviour
{
    public int plateCounter = 0;
    public int forkCounter = 0;
    public int cupCounter = 0;

    public GameObject gamePanel;
    public GameObject gameText;

    public AudioSource beep;

    public GameObject continueButton;

    private void Update()
    {
        //these numbers will be increased later
        if (plateCounter == 3 && forkCounter == 3 && cupCounter == 3 && GameObject.Find("GameManager").GetComponent<GameManager>().minigame3_complete == false)
        {
            StartCoroutine(DisplayText());
            GameObject.Find("GameManager").GetComponent<GameManager>().level++;
        }
    }

    IEnumerator DisplayText()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().minigame3_complete = true;
        Destroy(GameObject.Find("Platter"));
        gamePanel.SetActive(true);
        gameText.SetActive(true);
        beep.Play();
        yield return new WaitForSeconds(5);
        Destroy(gameText);
        continueButton.SetActive(true);
        beep.Play();
    }
}
