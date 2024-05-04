using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public Transform birbTransform;
    public float flapStrength;
    public float newRotation = -270;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        birbTransform.Rotate(0, 0, newRotation*Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) == true) 
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            birbTransform.Rotate(0, 0, 60);
        };

        
    }
}
