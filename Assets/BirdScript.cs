using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float jumpStrength = 5;
    // Start is called before the first frame update
    //
    void Start()
    {
    }

    private bool IsJumping() {
        // handle spacebar and mouse click or touch
        return Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) || Input.touchCount > 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsJumping())
        {

            rigidbody.velocity = Vector2.up * jumpStrength;
        }

    }
}
