using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJson;

    private void Update()
    {
        if (!DialogueManager.GetInstance().dialogueIsPlaying && DialogueManager.GetInstance().dialogueComplete == false && GameObject.Find("ExplainCanvas"))
        {
            DialogueManager.GetInstance().EnterDialogueMode(inkJson);
        }
    }

    public void SetInkJson(TextAsset ink)
    {
        inkJson = ink;
    }

}
