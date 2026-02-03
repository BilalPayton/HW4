using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    protected int _speed;
    

    protected virtual void Start()
    {
        _speed = 2;
    }
   protected void Update()
    {
        gameObject.transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Destroyer")
        {
            Destroy(gameObject);
        }
    }
}
