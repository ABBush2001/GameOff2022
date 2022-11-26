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
    public eventSystem eventSystem;

    void Start()
    {
        eCoffee = false;
    }
    void Update(){
    if(GameObject.Find("GameManager").GetComponent<GameManager>().level == 1){
        gameObject.layer = 7;
    }
    else gameObject.layer = 0;
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
