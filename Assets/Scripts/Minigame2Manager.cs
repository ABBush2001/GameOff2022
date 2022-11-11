using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame2Manager : MonoBehaviour
{
    public GameObject continueButton;
    public int score = 0;

    // Update is called once per frame
    void Update()
    {
        if(score == 5)
        {
            continueButton.SetActive(true);
        }
    }
}
