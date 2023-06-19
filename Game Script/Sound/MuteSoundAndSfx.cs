using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSoundAndSfx : MonoBehaviour
{
    [SerializeField]
    private AudioSource musicAudioSource;
    [SerializeField]
    private AudioSource sfxAudioSource;
    [SerializeField]
    private GameObject[] img;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MuteSFX()
    {
        sfxAudioSource.mute = !sfxAudioSource.mute;
        if(sfxAudioSource.mute == false)
        {
            img[2].SetActive(true);
            img[3].SetActive(false);

        }
        else
        {
            img[2].SetActive(false);
            img[3].SetActive(true);
        }
    }

    public void MuteMusic()
    {
        musicAudioSource.mute = !musicAudioSource.mute;
        if (musicAudioSource.mute == false)
        {
            img[0].SetActive(true);
            img[1].SetActive(false);

        }
        else
        {
            img[0].SetActive(false);
            img[1].SetActive(true);
        }
    }


}
