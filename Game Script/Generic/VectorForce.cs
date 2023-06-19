using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorForce : MonoBehaviour
{
    [SerializeField]
    private Vector2 force;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            collision.rigidbody.AddForce(force,ForceMode2D.Impulse);
        }
    }
}
