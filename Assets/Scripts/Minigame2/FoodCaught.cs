using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCaught : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Platter")
        {
            Destroy(this.gameObject);
            GameObject.Find("Minigame2Manager").GetComponent<Minigame2Manager>().score++;
        }
    }
}
