using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame1Manager : MonoBehaviour
{
    public int cookieCounter = 0;
    public int croissantCounter = 0;
    public int cupcakeCounter = 0;

    public GameObject continueButton;

    private void Update()
    {
        //these numbers will be increased later
        if(cookieCounter == 1 && croissantCounter == 1 && cupcakeCounter == 1)
        {
            continueButton.SetActive(true);
            GameObject.Find("GameManager").GetComponent<GameManager>().minigame1_complete = true;
        }
    }

}
