using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXController : MonoBehaviour
{
   public static SFXController instance;
    private void Awake()
    {
        instance = this;
    }

    [SerializeField]
    private AudioSource aud;
    [SerializeField]
    private AudioClip[] loseOrVictory;
    [SerializeField]
    private AudioClip[] generic;
    [SerializeField]
    private AudioClip[] paddle;
    [SerializeField]
    private AudioClip[] wallBounce;
    [SerializeField]
    private AudioClip[] brickDst;
    [SerializeField]
    private AudioClip[] brickDstNot;

    public void PlayLRV(int x)
    {
        aud.PlayOneShot(loseOrVictory[x]);
    }

    public void PlayGeneric(int x)
    {
        aud.PlayOneShot(generic[x]);
    }

    public void PaddlePlay(int x)
    {
        aud.PlayOneShot(paddle[x]);
    }

    public void PlayWallBounce(int x)
    {
        aud.PlayOneShot(wallBounce[x]);
    }

    public void PlayBrickDst(int x)
    {
        aud.PlayOneShot(brickDst[x]);
    }
    public void PlayBrickDstNot(int x)
    {
        aud.PlayOneShot(brickDstNot[x]);
    }
}
