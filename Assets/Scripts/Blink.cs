using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public GameObject l_eye;
    public GameObject r_eye;

    public GameObject l_eye_close;
    public GameObject r_eye_close;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(blink());
    }

    IEnumerator blink()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            l_eye.SetActive(false);
            r_eye.SetActive(false);
            l_eye_close.SetActive(true);
            r_eye_close.SetActive(true);
            yield return new WaitForSeconds(0.25f);
            l_eye_close.SetActive(false);
            r_eye_close.SetActive(false);
            l_eye.SetActive(true);
            r_eye.SetActive(true);
        }
    }

}
