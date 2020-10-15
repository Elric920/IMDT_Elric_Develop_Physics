using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallController : MonoBehaviour
{
    public float forcePower = 1.0f;
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        float posX = Input.GetAxis("Horizontal");
        float posY = Input.GetAxis("Vertical");
        if (posX>0)
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * forcePower;
        }
        else if (posX<0)
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.left * forcePower;
        }
        if (posY > 0)
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.forward * forcePower;
        }
        else if (posY < 0)
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.back * forcePower;
        }
    }
}
