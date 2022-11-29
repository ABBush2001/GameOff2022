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

    private void Start()
    {
        StartCoroutine(WaitOnStart());
    }

    // Update is called once per frame
    void Update()
    {
        if(score == 5)
        {
            StartCoroutine(DisplayText());
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
        yield return new WaitForSeconds(5);
        Destroy(gameText);
        continueButton.SetActive(true);
    }
}
