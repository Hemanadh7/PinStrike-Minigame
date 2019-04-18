using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float moveSpeed = 20.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A) && transform.position.x > -7.0f) { Move(-1); }
        if(Input.GetKey(KeyCode.D) && transform.position.x < 7.0f) { Move(1); }

        if (Input.GetKey(KeyCode.W)) { transform.Translate(new Vector3(0, 10.0f * Time.deltaTime, 0)); }
        if (Input.GetKey(KeyCode.S)) { transform.Translate(new Vector3(0, -10.0f * Time.deltaTime, 0)); }
    }

    void Move(int direction)
    {
        transform.Translate(new Vector3(direction * moveSpeed * Time.deltaTime, 0, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Object") { SceneManager.LoadScene(0); }
    }
}
