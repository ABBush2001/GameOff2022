using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuToUI : MonoBehaviour
{
    public void ToUI()
    {
        StartCoroutine(LoadUI());
    }

    IEnumerator LoadUI()
    {
        GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
        yield return new WaitForSeconds(5);
        GameObject.Find("EventSystem").GetComponent<LoadNextScene>().LoadScene(0);
    }
}
