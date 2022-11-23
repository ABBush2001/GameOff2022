using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame3Manager : MonoBehaviour
{
    public int plateCounter = 0;
    public int forkCounter = 0;
    public int cupCounter = 0;

    public GameObject continueButton;

    private void Update()
    {
        //these numbers will be increased later
        if (plateCounter == 1 && forkCounter == 1 && cupCounter == 1)
        {
            continueButton.SetActive(true);
        }
    }
}
