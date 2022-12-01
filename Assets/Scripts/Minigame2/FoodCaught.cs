using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodCaught : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Platter")
        {
            Destroy(this.gameObject.GetComponent<BoxCollider2D>());
            Destroy(this.gameObject.GetComponent<Rigidbody2D>());
            this.gameObject.transform.SetParent(collision.gameObject.transform);
            GameObject.Find("Minigame2Manager").GetComponent<Minigame2Manager>().score++;
            scoreText.text = GameObject.Find("Minigame2Manager").GetComponent<Minigame2Manager>().score.ToString();
            GameObject.Find("DropItemSound").GetComponent<AudioSource>().Play();
        }
    }
}
