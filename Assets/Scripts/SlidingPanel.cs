using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingPanel : MonoBehaviour
{
    public GameObject slidingPanel;

    float xPerSecond = 15;
    int counter = 0;
    bool startSlide = false;
    bool slideBack = false;

    public AudioSource slideUp;
    public AudioSource slideDown;

    private void Update()
    {
        if (startSlide)
        {

            slidingPanel.transform.Translate(new Vector3(xPerSecond * -1, 0, 0) * Time.deltaTime);

        }

        if(slideBack)
        {
            slidingPanel.transform.Translate(new Vector3(xPerSecond, 0, 0) * Time.deltaTime);
        }
            /*if(counter == 1500)
            {
                startSlide = false;
                GameObject.Find("ContinueButton").GetComponent<CanvasSwitcher>().SwitchCanvas();
                DialogueManager.GetInstance().button.SetActive(false);
                slideBack = true;
            }
        }

        if(slideBack)
        {
            if (counter > 0)
            {
                slidingPanel.transform.Translate(new Vector3(xPerSecond, 0, 0) * Time.deltaTime);
                counter--;
            }

            if(counter == 0)
            {
                slideBack = false;
            }
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "SlideTrigger")
        {
            StartCoroutine(ShowLevel());
        }
    }

    public void SlideAnimOpen()
    {
        slideUp.Play();
        startSlide = true;
    }

    /*public void SlideAnimClosed()
    {
        slideBack = true;
    }*/

    IEnumerator ShowLevel()
    {
        Debug.Log("Collided");
        startSlide = false;
        yield return new WaitForSeconds(3);
        GameObject.Find("ContinueButton").GetComponent<CanvasSwitcher>().SwitchCanvas();
        DialogueManager.GetInstance().button.SetActive(false);
        slideDown.Play();
        yield return new WaitForSeconds(1);
        slideBack = true;
    }
}
