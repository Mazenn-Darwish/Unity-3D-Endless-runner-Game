using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countdown3;
    public GameObject countdown2;
    public GameObject countdown1;
    public GameObject countdownGo;
    public GameObject fadeIn;
    public AudioSource readyFX;
    public AudioSource goFX;
    void Start()
    {
        StartCoroutine(CountSequence());
        
    }
IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1.5f);
        countdown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countdown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countdown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countdownGo.SetActive(true);
        goFX.Play();
        PlayerMovement.canMove = true;
    }
}
