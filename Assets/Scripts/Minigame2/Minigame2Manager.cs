using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame2Manager : MonoBehaviour
{
    public GameObject continueButton;
    public int score = 0;
    public bool start = false;

    private void Start()
    {
        StartCoroutine(WaitOnStart());
    }

    // Update is called once per frame
    void Update()
    {
        if(score == 5)
        {
            continueButton.SetActive(true);
            GameObject.Find("Minigame2Manager").GetComponent<SpawnInFood>().enabled = false;
            Destroy(GameObject.Find("Platter"));
        }
    }

    IEnumerator WaitOnStart()
    {
        yield return new WaitForSeconds(5);
        start = true;
    }
}
