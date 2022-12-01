using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInFood : MonoBehaviour
{
    private float lastActivity = 0.0f;

    public GameObject food1;
    public GameObject food2;
    public GameObject food3;
    public GameObject food4;
    public GameObject food5;
    public GameObject food6;

    void Update()
    {
        if(Time.time - lastActivity >= Random.Range(1, 2))
        {
            int item = Random.Range(1, 7);
            GameObject newFood;
            for (int i = 0; i < 3; i++)
            {
                if (item == 1)
                {
                    newFood = Instantiate(food1, GameObject.Find("Minigame2Canvas").transform);
                }
                else if (item == 2)
                {
                    newFood = Instantiate(food2, GameObject.Find("Minigame2Canvas").transform);
                }
                else if(item == 3)
                {
                    newFood = Instantiate(food3, GameObject.Find("Minigame2Canvas").transform);
                }
                else if(item == 4)
                {
                    newFood = Instantiate(food4, GameObject.Find("Minigame2Canvas").transform);
                }
                else if(item == 5)
                {
                    newFood = Instantiate(food5, GameObject.Find("Minigame2Canvas").transform);
                }
                else
                {
                    newFood = Instantiate(food6, GameObject.Find("Minigame2Canvas").transform);
                }
                newFood.transform.SetPositionAndRotation(new Vector3(Random.Range(-9, 9), newFood.transform.position.y), new Quaternion());
                Debug.Log(newFood.transform.position);
            }
            lastActivity = Time.time;
        }
    }
}
