using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInFood : MonoBehaviour
{
    private float lastActivity = 0.0f;

    public GameObject food;

    void Update()
    {
        if(Time.time - lastActivity >= 5.0f)
        {
            Instantiate(food, GameObject.Find("Minigame2Canvas").transform);
            lastActivity = Time.time;
        }
    }
}
