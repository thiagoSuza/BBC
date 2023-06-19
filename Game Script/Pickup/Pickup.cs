using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField]
    private GameObject laser;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            SelectAction();
            Destroy(gameObject);
        }
    }

    public void SelectAction()
    {
        int x = Random.Range(0, 6);
        switch (x)
        {
                case 0:
                GameManager.instance.TimeFast();
                break;
                case 1:
                GameManager.instance.TimeSlow();
                break;
                case 2:
                GameManager.instance.LifeUp();
                break;
                case 3:
                GameManager.instance.DoubleBall();
                break;
                case 4:
                Shoot();
                break;
                case 5:
                break;
        }
    }

   public void Shoot()
   {
        Instantiate(laser,transform.position,transform.rotation);
   }
}
