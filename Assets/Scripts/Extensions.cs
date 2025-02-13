using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
    public static bool DotTest(this Transform transform, Transform other, Vector3 testDirection){
        Vector3 direction = other.position - transform.position;
        return Vector3.Dot(direction.normalized, testDirection) > 0.25f ;
    }
 
}
