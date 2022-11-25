using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(DialogueManager.GetInstance().button && InputManager.GetInstance().GetInteractPressed())
        {
            if (GameObject.Find("Minigame1Manager") || GameObject.Find("Minigame2Manager") || GameObject.Find("Minigame3Manager"))
            {
                try
                {
                    //load in new scene
                    GameObject.Find("GameManager").GetComponent<LoadNextScene>().LoadScene(1);
                }
                catch
                {
                    Debug.Log("pressed too early!");
                }
            }
            else
            {
                try
                {
                    GameObject.Find("ContinueButton").GetComponent<CanvasSwitcher>().SwitchCanvas();
                }
                catch
                {
                    Debug.Log("pressed too early");
                }
            }
            //reset dialogue complete and button
            DialogueManager.GetInstance().dialogueComplete = false;
            DialogueManager.GetInstance().button.SetActive(false);
        }
    }
}
