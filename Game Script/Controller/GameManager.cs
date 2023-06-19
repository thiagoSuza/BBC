using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Intersticial ads;

    [SerializeField]
    private int life;

    private int pointsToWin;

    [SerializeField]
    private int victoryPoints;

    [SerializeField]
    private GameObject gameOverPanel;

    [SerializeField]
    private GameObject victoryPanel;

    [SerializeField]
    private GameObject ball;

    [SerializeField]
    private Transform spawnPoint;

    [SerializeField]
    private Text lifeText;
    [SerializeField]
    private string key;

    public bool allowToMove;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        life = 2;
        pointsToWin = 0;
        lifeText.text = life.ToString();
        allowToMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        life--;
        lifeText.text = life.ToString();
        
        Instantiate(ball, spawnPoint.position,transform.rotation);
        SFXController.instance.PlayGeneric(0);
        if(life == 0)
        {
            AdsCondition();
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
            SFXController.instance.PlayLRV(1);
            allowToMove = false;
        }
    }

    public void IncrescePoints()
    {
        pointsToWin++;
        if(pointsToWin == victoryPoints)
        {
            SaveMission();
            victoryPanel.SetActive(true);
            Time.timeScale = 0;
            SFXController.instance.PlayLRV(0);
        }
    }

    public void ResetLife()
    {
        life = 2;
        lifeText.text = life.ToString();
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
        allowToMove = true;
    }

    public void SaveMission()
    {
        PlayerPrefs.SetInt(key, 1);
    }

    public void TimeFast()
    {
        StartCoroutine(Fast());
    }

    public void TimeSlow()
    {
        StartCoroutine(Slow());
    }

    public void LifeUp()
    {
        life++;
        lifeText.text = life.ToString();
    }

    IEnumerator Fast()
    {
        Time.timeScale = 2f;
        yield return new WaitForSecondsRealtime(2f);
        Time.timeScale = 1f;
    }

    IEnumerator Slow()
    {
        Time.timeScale = .5f;
        yield return new WaitForSecondsRealtime(2f);
        Time.timeScale = 1f;
    }

    public void DoubleBall()
    {
        Instantiate(ball, spawnPoint.position, transform.rotation);
    }

    public void LoadADS()
    {
        
        ads.LoadAd();
    }

    public void AdsCondition()
    {
        int aux = PlayerPrefs.GetInt("Inter",0);
        aux++;
        if(aux == 5)
        {
            LoadADS();
            PlayerPrefs.SetInt("Inter", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Inter", aux);
            aux = 0;
        }
    }
    
}
