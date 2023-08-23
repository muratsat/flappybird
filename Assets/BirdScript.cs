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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {

            rigidbody.velocity = Vector2.up * jumpStrength;
        }

    }
}
