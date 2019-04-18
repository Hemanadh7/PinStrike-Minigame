using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pin : MonoBehaviour {

    public float speed = 5.0f;

    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rotor rot = collision.GetComponent<Rotor>();
        if (rot)
        {
            speed = 0.0f;
            transform.SetParent(rot.transform);
        }

        if (collision.tag == "Head")
        {
            SceneManager.LoadScene(1);
        }
    }
}
