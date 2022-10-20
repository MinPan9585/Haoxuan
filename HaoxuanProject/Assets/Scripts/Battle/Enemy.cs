using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float xSpeed;
    public float rotationSpeed;

    void Start()
    {
        //rotationSpeed = Random.Range();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(xSpeed * Time.deltaTime, 0, 0);
        transform.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime));
    }
}
