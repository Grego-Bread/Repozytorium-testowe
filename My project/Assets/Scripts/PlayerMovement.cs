using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed = 2;

    public Rigidbody rigidbody;
    public Transform startPoint;
    public Transform endPoint;
    public int zebranePunkty;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            transform.position = startPoint.position;
            rigidbody.velocity = Vector3.zero;
        }


        if (Input.GetAxis("Horizontal") != 0)
        {
            float directionHorizontal = Input.GetAxis("Horizontal");

            rigidbody.AddForce(0, 0, directionHorizontal * Time.deltaTime * Speed, ForceMode.Impulse);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            float directionVertical = Input.GetAxis("Vertical");

            rigidbody.AddForce(directionVertical * Time.deltaTime * Speed * -1, 0, 0, ForceMode.Impulse);
        }

        
    }

}
