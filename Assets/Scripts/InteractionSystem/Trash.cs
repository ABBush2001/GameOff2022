using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trash : MonoBehaviour, IInteractable
{
    public TextMeshProUGUI dialogue;
    public int waitTime; 
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    private eventSystem eventSystem;


    void Start()
    {
        eventSystem = GameObject.Find("EventSystem").GetComponent<eventSystem>();
    }
    void Update(){
        if(eventSystem.level == 2){
            gameObject.layer = 7;
        }
        else gameObject.layer = 0;
    }

    public bool Interact(Interactor interactor)
    {
        Debug.Log("");
        dialogue.text =  _prompt;
        eventSystem.trashGrab++;
        Destroy(gameObject);
        StartCoroutine(waitCoroutine());
        return true;
        

    }

    IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(waitTime);
        dialogue.text = "";

    }
}