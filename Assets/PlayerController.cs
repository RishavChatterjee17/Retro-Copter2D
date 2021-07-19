using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float jumpSpeed = 10.0f;
    float scrollSpeed = 25.0f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start () {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void FixedUpdate () {

        rb.AddForce(gameObject.transform.right * scrollSpeed);

        if (Input.GetMouseButton (0)) {
            {
                // Debug.Log ("Mouse Clicked");
                rb.AddForce (gameObject.transform.up * jumpSpeed);
            }
        }

    }
}