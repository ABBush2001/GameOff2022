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

    private AudioSource soundfx;


    void Start()
    {
        eComputer = false;
        soundfx = GetComponent<AudioSource>();
    }

    public bool Interact(Interactor interactor)
    {
        Debug.Log("interacted with computer");
        if(GameObject.Find("GameManager").GetComponent<GameManager>().level == 1)
        {
            if(eventSystem.coffee.eCoffee && eventSystem.toothBrush.eTooth){
                eComputer = true;
                //GameObject.Find("GameManager").GetComponent<GameManager>().level++;
                StartCoroutine(waitCoroutine());
                //load next minigame
            }
            else {
            dialogue.text = _prompt;
            //StartCoroutine(waitCoroutine());
            }
        }
        else if(GameObject.Find("GameManager").GetComponent<GameManager>().level == 2){
            if(eventSystem.trashGrab >= 3){
                eComputer = true;
                //GameObject.Find("GameManager").GetComponent<GameManager>().level++;
                StartCoroutine(waitCoroutine());
                //load next minigame
            }
            else {
            dialogue.text = _prompt;
            //StartCoroutine(waitCoroutine());
        }
        }
        return true;
        

    }

    IEnumerator waitCoroutine()
    {
        dialogue.text = "";
        soundfx.Play();
        GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
        yield return new WaitForSeconds(waitTime);
        GameObject.Find("GameManager").GetComponent<LoadNextScene>().LoadScene(1);
    }
}