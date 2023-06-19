using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker : MonoBehaviour
{
    [SerializeField]
    private Button[] btns;
    [SerializeField]
    private GameObject[] select;
    [SerializeField]
    private GameObject[] padlock;
    // Start is called before the first frame update
    void Start()
    {
        Unlocker();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Unlocker()
    {
        if (PlayerPrefs.GetInt("Level2") == 1)
        {
            btns[0].interactable = true;
            select[0].SetActive(true);
            padlock[0].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Level3") == 1)
        {
            btns[1].interactable = true;
            select[1].SetActive(true);
            padlock[1].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Level4") == 1)
        {
            btns[2].interactable = true;
            select[2].SetActive(true);
            padlock[2].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Level5") == 1)
        {
            btns[3].interactable = true;
            select[3].SetActive(true);
            padlock[3].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Level6") == 1)
        {
            btns[4].interactable = true;
            select[4].SetActive(true);
            padlock[4].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Level7") == 1)
        {
            btns[5].interactable = true;
            select[5].SetActive(true);
            padlock[5].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Level8") == 1)
        {
            btns[6].interactable = true;
            select[6].SetActive(true);
            padlock[6].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Level9") == 1)
        {
            btns[7].interactable = true;
            select[7].SetActive(true);
            padlock[7].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Level10") == 1)
        {
            btns[8].interactable = true;
            select[8].SetActive(true);
            padlock[8].SetActive(false);
        }
    }
}
