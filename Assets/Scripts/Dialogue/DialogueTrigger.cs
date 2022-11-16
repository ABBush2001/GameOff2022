using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJson;

    public GameObject gameManager;

    public TextAsset inkJson1;

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
            else
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJson);
            }
        }
    }

    public void SetInkJson(TextAsset ink)
    {
        inkJson = ink;
    }

}
