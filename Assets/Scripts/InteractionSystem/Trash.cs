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

    private AudioSource soundfx;

    void Start()
    {
        eventSystem = GameObject.Find("ApartmentManager").GetComponent<eventSystem>();
        soundfx = GetComponent<AudioSource>();
    }
    void Update(){
        if(GameObject.Find("GameManager").GetComponent<GameManager>().level == 2){
            gameObject.layer = 7;
        }
        else gameObject.layer = 0;
    }

    public bool Interact(Interactor interactor)
    {
        Debug.Log("");
        dialogue.text =  _prompt;
        eventSystem.trashGrab++;
        soundfx.Play();
        StartCoroutine(waitCoroutine());
        
        
        return true;
        

    }

    IEnumerator waitCoroutine()
    {
        
        GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(3);
        
        Destroy(gameObject);
        dialogue.text = "";

    }
}