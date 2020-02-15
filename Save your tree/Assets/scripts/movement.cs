using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float x, y;
    public float speed;
   
    void Start()
    {
        speed = 30f;
    }

    void Update()
    {
        y = Input.GetAxis("Vertical") * 30 * speed * Time.fixedDeltaTime;
        x = Input.GetAxis("Horizontal") * 30 * speed * Time.fixedDeltaTime;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(x, y));
    }
}
