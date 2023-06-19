using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSetColor : MonoBehaviour
{
    [SerializeField]
    private int index;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            collision.gameObject.GetComponent<BallController>().ChangeColor(index);
            int x = Random.Range(0, 4);
            SFXController.instance.PaddlePlay(x);
            
        }
    }
}
