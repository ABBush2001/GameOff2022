using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Bed : MonoBehaviour, IInteractable
{
    public TextMeshProUGUI dialogue;
    public int waitTime; 
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    public eventSystem eventSystem;

    void Start()
    {

    }
    void Update(){
    if(GameObject.Find("GameManager").GetComponent<GameManager>().level == 3){
        gameObject.layer = 7;
    }
    else gameObject.layer = 0;
    }

    public bool Interact(Interactor interactor)
    {
        Debug.Log("interacted with bed");
        //load final
        StartCoroutine(FadeToCredits());
        return true;
        

    }

    IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(waitTime);
        dialogue.text = "";

    }

    IEnumerator FadeToCredits()
    {
        GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Credits");
    }
}