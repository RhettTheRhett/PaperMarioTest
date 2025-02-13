using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            if (collision.transform.DotTest(transform, Vector3.up)) {
                Debug.Log("Hit from bottom");
            }
        }
    }
}
