using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;

public class DialogueManager : MonoBehaviour
{
    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;

    private Story currentStory;
    public bool dialogueIsPlaying { get; private set; }

    public bool dialogueComplete = false;
    public GameObject button;

    public AudioSource beep;

    private static DialogueManager instance;

    int counter = 0;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue manager in the scene!");
        }
        instance = this;
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start()
    {

        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        button.SetActive(false);
    }

    private void Update()
    {
        if (!dialogueIsPlaying)
        {
            return;
        }

        if (InputManager.GetInstance().GetSubmitPressed())
        {
            ContinueStory();
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        StartCoroutine(WaitAtStart());
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        ContinueStory();

    }

    public void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        Debug.Log("Exit");
        dialogueText.text = "";
        dialogueComplete = true;
        button.SetActive(true);
        GameObject.Find("Person").GetComponent<OpenMouth>().closeM();
        GetInstance().enabled = false;
    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            dialogueText.text = currentStory.Continue();
            if (counter != 0)
            {
                beep.Play();
                Debug.Log("Continue");
            }
            counter++;
        }
        else
        {
            beep.Play();
            ExitDialogueMode();
        }
    }

    IEnumerator WaitAtStart()
    {
        yield return new WaitForSeconds(5);
        dialoguePanel.SetActive(true);
        //beep.Play();
        GameObject.Find("Person").GetComponent<OpenMouth>().openM();
        
        //dialoguePanel.SetActive(true);

        
    }
}