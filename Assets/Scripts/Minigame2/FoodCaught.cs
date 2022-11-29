using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCaught : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Platter")
        {
            Destroy(this.gameObject.GetComponent<BoxCollider2D>());
            Destroy(this.gameObject.GetComponent<Rigidbody2D>());
            this.gameObject.transform.SetParent(collision.gameObject.transform);
            GameObject.Find("Minigame2Manager").GetComponent<Minigame2Manager>().score++;
        }
    }
}
