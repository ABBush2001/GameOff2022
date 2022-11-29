using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTurn : MonoBehaviour
{
    public GameObject Head;
    public GameObject Ponytail;

    float degreesPerSecond = 1;
    bool topReached = false;
    int counter = 0;

    // Update is called once per frame
    void Update()
    {
        if (counter < 2500)
        {
            if (topReached == false)
            {
                Head.transform.Rotate(new Vector3(0, 0, degreesPerSecond) * Time.deltaTime);
                Ponytail.transform.Rotate(new Vector3(0, 0, degreesPerSecond) * Time.deltaTime);
                counter++;

                if (counter == 2500)
                {
                    topReached = true;
                }
            }
        }

        if (counter > 0)
        {
            if (topReached)
            {
                Head.transform.Rotate(new Vector3(0, 0, degreesPerSecond * -1) * Time.deltaTime);
                Ponytail.transform.Rotate(new Vector3(0, 0, degreesPerSecond * -1) * Time.deltaTime);
                counter--;

                if (counter == 0)
                {
                    topReached = false;
                }
            }
        }
    }
}
