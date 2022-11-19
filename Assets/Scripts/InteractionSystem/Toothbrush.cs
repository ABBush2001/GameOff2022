using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Toothbrush : MonoBehaviour, IInteractable
{
    public TextMeshProUGUI dialogue;
    public int waitTime;
    public bool eTooth;
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    void Start()
    {
        eTooth = false;
    }

    public bool Interact(Interactor interactor)
    {
        dialogue.text =  _prompt;
        eTooth = true;
        StartCoroutine(waitCoroutine());
        return true;
        

    }

    IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(waitTime);
        dialogue.text = "";

    }
}
