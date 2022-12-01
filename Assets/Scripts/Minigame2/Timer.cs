using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public int timer = 0;
    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        timer = 20;
        timerText.text = timer.ToString();
    }

    public IEnumerator Countdown()
    {
        while(timer > 0)
        {
            yield return new WaitForSeconds(1);
            timer--;
            timerText.text = timer.ToString();
        }
    }
}
