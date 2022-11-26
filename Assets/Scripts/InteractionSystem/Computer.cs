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
        if(GameObject.Find("GameManager").GetComponent<GameManager>().level == 1)
        {
            if(eventSystem.coffee.eCoffee && eventSystem.toothBrush.eTooth){
                eComputer = true;
                GameObject.Find("GameManager").GetComponent<GameManager>().level++;
                StartCoroutine(waitCoroutine());
                //load next minigame
            }
            else {
            dialogue.text = _prompt;
            StartCoroutine(waitCoroutine());
            }
        }
        else if(GameObject.Find("GameManager").GetComponent<GameManager>().level == 2){
            if(eventSystem.trashGrab >= 3){
                eComputer = true;
                GameObject.Find("GameManager").GetComponent<GameManager>().level++;
                StartCoroutine(waitCoroutine());
                //load next minigame
            }
            else {
            dialogue.text = _prompt;
            StartCoroutine(waitCoroutine());
        }
        }
        return true;
        

    }

    IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(waitTime);
        dialogue.text = "";
        GameObject.Find("GameManager").GetComponent<LoadNextScene>().LoadScene(0);
    }
}