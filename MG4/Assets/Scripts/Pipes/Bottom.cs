using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : Pipe
{

    protected override void Start()
    {
        base.Start();
        gameObject.transform.position = new Vector3(4.44f, -3.34f, 0);
        gameObject.transform.localScale = new Vector3(2.65f, Random.Range(3, 13), 0);

    }

}
