using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmSwing : MonoBehaviour
{
    public GameObject leftArm;
    public GameObject rightArm;

    float degreesPerSecond = 3;
    bool topReached = false;
    int counter = 0;

    private void Update()
    {
        if (counter < 2500)
        {
            if (topReached == false)
            {
                leftArm.transform.Rotate(new Vector3(0, 0, degreesPerSecond * -1) * Time.deltaTime);
                rightArm.transform.Rotate(new Vector3(0, 0, degreesPerSecond) * Time.deltaTime);
                counter++;

                if(counter == 2500)
                {
                    topReached = true;
                }
            }
        }

        if(counter > 0)
        {
            if (topReached)
            {
                leftArm.transform.Rotate(new Vector3(0, 0, degreesPerSecond) * Time.deltaTime);
                rightArm.transform.Rotate(new Vector3(0, 0, degreesPerSecond * -1) * Time.deltaTime);
                counter--;

                if(counter == 0)
                {
                    topReached = false;
                }
            }
        }
    }

    
}
