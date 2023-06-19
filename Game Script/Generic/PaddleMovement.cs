using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.allowToMove)
        {
            Movement();
        }
        
    }

    public void Movement()
    {


        if(Input.touchCount>0)
        {
            Touch t = Input.GetTouch(0);
            if(t.phase == TouchPhase.Moved)
            {
               Vector3 pos = Camera.main.ScreenToWorldPoint(t.position);
                pos.z = 0;
                pos.y = -3.925f;
                transform.position = pos;
            }
        }

       
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
}
