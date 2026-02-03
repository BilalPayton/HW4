using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : Pipe
{
    protected override void Start()
    {
        _speed = -2;
        gameObject.transform.position = new Vector3(4.44f, 4.43f, 0);
        gameObject.transform.localScale = new Vector3(2.65f, Random.Range(3, 15), 0);
    }
}
