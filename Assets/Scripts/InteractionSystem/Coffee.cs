using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coffee : MonoBehaviour, IInteractable
{
    public TextMeshProUGUI dialogue;
    public int waitTime;
    public bool eCoffee; 
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    void Start()
    {
        eCoffee = false;
    }

    public bool Interact(Interactor interactor)
    {
        Debug.Log("interacted with coffee");
        dialogue.text =  _prompt;
        eCoffee = true;
        StartCoroutine(waitCoroutine());
        return true;
        

    }

    IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(waitTime);
        dialogue.text = "";

    }
}
