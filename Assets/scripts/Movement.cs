using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    void Update()
    {
        //if(Input.GetKey(KeyCode.D))
        //{
        //    transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.E))
        //{
        //    transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        //}
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
        //}

        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, 0, z).normalized*speed*Time.deltaTime;


        


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("emeny"))
        {
            print("game over");
        }
    }
}
