using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    [SerializeField]
    private GameObject psEffect;
    [SerializeField]
    private GameObject coletable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destroyer()
    {
       /* int x = Random.Range(0, 25);
        if(x < 2)
        {
            Instantiate(coletable, transform.position, Quaternion.identity);
        }*/
        GameManager.instance.IncrescePoints();
        Instantiate(psEffect,transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
