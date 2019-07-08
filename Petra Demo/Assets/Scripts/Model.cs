using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
   
    public AudioClip audio;
    bool isActiveSound = false;
    public void playAudio()
    {
        transform.GetComponent<AudioSource>().clip = audio;
        transform.GetComponent<AudioSource>().Play();
    }
  public void stopPlaying()
    {
        transform.GetComponent<AudioSource>().Stop();
    }



public void TrigerSound()
{
    isActiveSound = !isActiveSound;
    ActiveSound();
}

void ActiveSound()
{
    if (isActiveSound)
    {

        print("isActiveSound" + isActiveSound);
        transform.GetComponent<Model_>().playAudio();
    }
    else
    {
        transform.GetComponent<Model_>().stopPlaying();

    }
}
    

}