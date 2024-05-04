using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public Transform birbTransform;
    public float flapStrength;
    public float newRotation = 90;
    public Vector3 rotateAmount = new Vector3(0, 0, 60);
    private double timeSinceFlap = 2;

    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Angle(Vector3.up, birbTransform.up) <= 90 & timeSinceFlap >= 2)
        {
            //Debug.Log(Vector3.Angle(Vector3.up, birbTransform.up));
            birbTransform.Rotate(0, 0, -newRotation);
        }


        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength; // Take the bird up!

            timeSinceFlap = 0;
            FlapRotate();
            
        }
    }
    void FlapRotate()
    {
        while (timeSinceFlap < 2)
        {
            timeSinceFlap += Time.deltaTime;
            birbTransform.Rotate(0, 0, 60f, Space.Self);
        }
    }
}
