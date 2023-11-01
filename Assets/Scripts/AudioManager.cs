using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource StartGame;
    public AudioSource NormalStateBackground;
    // Start is called before the first frame update
    void Start()
    {
        StartGame.Play();
        Invoke("PlayNormalStateBackground", StartGame.clip.length);
    }

    // Update is called once per frame
    void Update()
    {
        NormalStateBackground.Play();
    }
}
