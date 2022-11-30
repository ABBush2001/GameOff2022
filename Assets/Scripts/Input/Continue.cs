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
            if ((GameObject.Find("Minigame1Manager") && GameObject.Find("GameManager").GetComponent<GameManager>().minigame1_complete == true) || (GameObject.Find("Minigame2Manager") && GameObject.Find("GameManager").GetComponent<GameManager>().minigame2_complete == true) || (GameObject.Find("Minigame3Manager") && GameObject.Find("GameManager").GetComponent<GameManager>().minigame3_complete == true))
            {
                try
                {
                    //load in new scene
                    StartCoroutine(ChangeScenes());
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
                    GameObject.Find("SlidingPanel").GetComponent<SlidingPanel>().SlideAnimOpen();
                    //GameObject.Find("ContinueButton").GetComponent<CanvasSwitcher>().SwitchCanvas();
                    //GameObject.Find("SlidingPanel").GetComponent<SlidingPanel>().SlideAnimClosed();
                }
                catch
                {
                    Debug.Log("pressed too early");
                }
            }
            //reset dialogue complete and button
            DialogueManager.GetInstance().dialogueComplete = false;
            //DialogueManager.GetInstance().button.SetActive(false);
        }
    }

    IEnumerator ChangeScenes()
    {
        GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
        yield return new WaitForSeconds(5);
        GameObject.Find("GameManager").GetComponent<LoadNextScene>().LoadScene(1);
    }
}
