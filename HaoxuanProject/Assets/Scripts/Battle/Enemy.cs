using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int dir = 1;
    public float xSpeed;
    public float rotationSpeed;
    public GameObject haloGetHit;
    public Sprite redCircle;
    public Sprite blueCircle;

    void Start()
    {
        //rotationSpeed = Random.Range();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(xSpeed * dir * Time.deltaTime, 0, 0);
        transform.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime));

        if (Mathf.Abs(transform.position.x - 0) <= 0.1f)
        {
            //Debug.Log("enemy hit player");

            Instantiate(haloGetHit, Vector3.zero, Quaternion.identity);
            GameObject.Find("Player").GetComponent<PlayerController>().LoseHealth();
            GameObject.Find("Player").GetComponent<SpriteRenderer>().sprite = redCircle;
            Invoke("BackBlue", 0.3f);
        }
    }

    void BackBlue()
    {
        GameObject.Find("Player").GetComponent<SpriteRenderer>().sprite = blueCircle;
        Destroy(this.gameObject);
    }
}
