using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    public float padding = 1f;
    // Use this for initialization
    float xmin;
    float xmax;
    void Start()
    {
        //distance between camera and player
        float distance = transform.position.z - Camera.main.transform.position.z;

        Vector3 leftMost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 rightMost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));

        xmin = leftMost.x + padding;
        xmax = rightMost.x - padding;
    }

    // Update is called once per frame
    void Update()
    {
       
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
