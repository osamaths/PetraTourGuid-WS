using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour {
    public string name;
    public GameObject model;
    public string description;
    public List<ModelAudio> audios;

    [System.Serializable]
    public class ModelAudio
    {
        public AudioClip audio;
        public string language;
    }
}
