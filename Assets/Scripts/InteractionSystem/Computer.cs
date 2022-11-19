using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Computer : MonoBehaviour, IInteractable
{
    public TextMeshProUGUI dialogue;
    public int waitTime;
    public bool eComputer; 
    public eventSystem eventSystem;
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    void Start()
    {
        eComputer = false;
    }

    public bool Interact(Interactor interactor)
    {
        Debug.Log("interacted with computer");
        if(eventSystem.level == 1)
        {
            if(eventSystem.coffee.eCoffee && eventSystem.toothBrush.eTooth){
                dialogue.text =  _prompt;
                eComputer = true;
                StartCoroutine(waitCoroutine());
                //load next minigame
            }
        }
        return true;
        

    }

    IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(waitTime);
        dialogue.text = "";

    }
}