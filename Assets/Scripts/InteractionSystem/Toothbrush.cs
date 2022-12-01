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
    public eventSystem eventSystem;

    private AudioSource soundfx;

    void Start()
    {
        eTooth = false;
        soundfx = GetComponent<AudioSource>();
        
    }

    void Update(){
        if(GameObject.Find("GameManager").GetComponent<GameManager>().level == 1){
            gameObject.layer = 7;
        }
        else gameObject.layer = 0;
    }

    public bool Interact(Interactor interactor)
    {
        dialogue.text =  _prompt;
        eTooth = true;
        soundfx.Play();
        StartCoroutine(waitCoroutine());
        return true;
        

    }

    IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(waitTime);
        dialogue.text = "";

    }
}
