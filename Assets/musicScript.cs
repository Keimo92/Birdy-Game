using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicScript : MonoBehaviour
{

    public AudioSource audiosource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        audiosource.GetComponent<AudioSource>();
        Play();
    }

    // Update is called once per frame
    void Update()
    {
        

    }


    public void Play()
    {
        audiosource.clip = clip;
        audiosource.Play();
        
    }
}
