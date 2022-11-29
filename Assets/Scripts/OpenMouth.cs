using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMouth : MonoBehaviour
{
    public GameObject mouth;
    public GameObject openMouth;

    public void openM()
    {
        mouth.SetActive(false);
        openMouth.SetActive(true);
    }

    public void closeM()
    {
        openMouth.SetActive(false);
        mouth.SetActive(true);
    }
}
