using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour {
    //public string name;
    //public GameObject model;
    //public string description;
    public AudioClip audio;

    internal void playAudio()
    {
        transform.GetComponent<AudioSource>().clip = audio;
        transform.GetComponent<AudioSource>().Play();
    }


    //[System.Serializable]
    //public class ModelAudio
    //{
    //    public AudioClip audio;
    //    public string language;
    //}
}
