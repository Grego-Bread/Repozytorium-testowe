using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObstacelController : MonoBehaviour
{
    public Transform PointStart;
    public Transform PointEnd;

    bool isMovingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingRight)
        {
            transform.Translate(0, 0, 1 * Time.deltaTime);

            if (transform.position.z > PointEnd.position.z)
            {
                isMovingRight = false;
            }
        }
        else
        {
            transform.Translate(0, 0, -1 * Time.deltaTime);

            if (transform.position.z < PointStart.position.z)
            {
                isMovingRight = true;
            }
        }
    }
}
