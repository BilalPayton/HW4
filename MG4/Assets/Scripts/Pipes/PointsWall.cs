using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsWall : Pipe
{
    protected override void Start()
    {
        base.Start();
        gameObject.transform.position = new Vector3(5.44f, 4.43f, 0);
    }
}
