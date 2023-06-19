using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeedController : MonoBehaviour
{
    [SerializeField]
    private float speedLimitUp;
    [SerializeField]
    private float speedLimitDown;
    

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        SpeedLimite();
    }

    public void SpeedLimite()
    {
        if(rb.velocity.magnitude > speedLimitUp)
        {
            rb.velocity = rb.velocity.normalized * speedLimitUp;
        }

        if (rb.velocity.magnitude < speedLimitDown)
        {
            rb.velocity = rb.velocity.normalized * speedLimitDown;
        }
    }

  
}
