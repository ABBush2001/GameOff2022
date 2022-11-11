using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCaught : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Platter")
        {
            Debug.Log("Test");
        }
    }
}
