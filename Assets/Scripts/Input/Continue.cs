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
            try
            {
                GameObject.Find("ContinueButton").GetComponent<CanvasSwitcher>().SwitchCanvas();
            }
            catch
            {
                Debug.Log("pressed too early!");
            }
            //reset dialogue complete and button
            DialogueManager.GetInstance().dialogueComplete = false;
            DialogueManager.GetInstance().button.SetActive(false);
        }
    }
}
