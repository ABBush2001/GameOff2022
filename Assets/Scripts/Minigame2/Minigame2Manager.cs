using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame2Manager : MonoBehaviour
{
    public GameObject continueButton;
    public int score = 0;
    public bool start = false;

    public GameObject gamePanel;
    public GameObject gameText;

    public AudioSource beep;

    private void Start()
    {
        StartCoroutine(WaitOnStart());
        StartCoroutine(GameObject.Find("Minigame2Manager").GetComponent<Timer>().Countdown());
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Minigame2Manager").GetComponent<Timer>().timer == 0 && GameObject.Find("GameManager").GetComponent<GameManager>().minigame2_complete == false)
        {
            StartCoroutine(DisplayText());
            GameObject.Find("GameManager").GetComponent<GameManager>().level++;
        }
    }

    IEnumerator WaitOnStart()
    {
        yield return new WaitForSeconds(5);
        start = true;
    }

    IEnumerator DisplayText()
    {
        GameObject.Find("Minigame2Manager").GetComponent<SpawnInFood>().enabled = false;
        GameObject.Find("GameManager").GetComponent<GameManager>().minigame2_complete = true;
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
