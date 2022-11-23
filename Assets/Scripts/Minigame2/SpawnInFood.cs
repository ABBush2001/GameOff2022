using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInFood : MonoBehaviour
{
    private float lastActivity = 0.0f;

    public GameObject food;

    void Update()
    {
        if(Time.time - lastActivity >= Random.Range(1, 5))
        {
            GameObject newFood = Instantiate(food, GameObject.Find("Minigame2Canvas").transform);
            newFood.transform.SetPositionAndRotation(new Vector3(Random.Range(-9, 9), newFood.transform.position.y), new Quaternion());
            Debug.Log(newFood.transform.position);
            lastActivity = Time.time;
        }
    }
}
