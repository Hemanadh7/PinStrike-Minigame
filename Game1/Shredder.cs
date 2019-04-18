using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shredder : MonoBehaviour {

    public Text scoreText;
    int score;

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        Destroy(collision.gameObject);
    }
}
