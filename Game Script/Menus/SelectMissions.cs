using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectMissions : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
        

    public void LoadLevel(int x)
    {
        SceneManager.LoadScene(x);
    }
}
