using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJson;

    public GameObject gameManager;

    public TextAsset inkJson1;
    public TextAsset inkJson2;
    public TextAsset inkJson3;
    public TextAsset inkJson4;

    private void Update()
    {
        if (!DialogueManager.GetInstance().dialogueIsPlaying && DialogueManager.GetInstance().dialogueComplete == false && GameObject.Find("ExplainCanvas"))
        {
            if (gameManager.GetComponent<GameManager>().minigame1_complete == false)
            {
                gameManager.GetComponent<GameManager>().minigame1_complete = true;
                inkJson = inkJson1;
                DialogueManager.GetInstance().EnterDialogueMode(inkJson);
            }
            else if(gameManager.GetComponent<GameManager>().minigame2_complete == false)
            {
                gameManager.GetComponent<GameManager>().minigame2_complete = true;
                DialogueManager.GetInstance().EnterDialogueMode(inkJson2);
            }
            else if(gameManager.GetComponent<GameManager>().minigame3_complete == false)
            {
                gameManager.GetComponent<GameManager>().minigame3_complete = true;
                DialogueManager.GetInstance().EnterDialogueMode(inkJson3);
            }
            else
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJson4);
            }
        }
    }

    public void SetInkJson(TextAsset ink)
    {
        inkJson = ink;
    }

}
