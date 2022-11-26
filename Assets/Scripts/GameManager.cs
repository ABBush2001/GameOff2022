using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool minigame1_complete = false;
    public bool minigame2_complete = false;
    public bool minigame3_complete = false;

    public bool mouseOn = false;

    public int level;

    // Update is called once per frame
    void Update()
    {
        if(mouseOn == false && GameObject.Find("ExplainCanvas"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            mouseOn = true;
        }
    }
}
