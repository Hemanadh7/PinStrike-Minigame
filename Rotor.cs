using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotor : MonoBehaviour {

    public float speedRotation = 20.0f;
    int score = 0;
    public Text text;

    private void Update()
    {
        if (Time.time > 60 )
        {
            speedRotation = 5;
        }
        transform.Rotate(new Vector3(0, 0, speedRotation));
        text.text = score.ToString();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Pin pin = collision.GetComponent<Pin>();
        if (pin) { score++; }
    }
}
