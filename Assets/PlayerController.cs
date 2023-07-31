using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 newPos = Vector3.zero;

    float movementSpeed = 0.001f;
    bool breadFound = false;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (!breadFound)
        {
            newPos = GameObject.FindGameObjectWithTag("Bread").transform.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, newPos, movementSpeed);
        movementSpeed += 0.001f * Time.deltaTime;

    }
}
