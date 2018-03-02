using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xmin = -5;
        float xmax = 5;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position += new Vector3(-speed *Time.deltaTime, 0, 0);
            //alternative implementation
            transform.position += Vector3.left * speed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        //will be the transform potion of the X value of the transform but clamped between the min and max
        float newX = Mathf.Clamp(transform.position.x, xmin, xmax);
        //restrict player to the gamespace
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);


    }


}
