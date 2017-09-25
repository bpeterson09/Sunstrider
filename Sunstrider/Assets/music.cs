using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour {

    public AudioClip background;
    public AudioClip background2;
    public AudioClip background3;
    private AudioSource audio2;
    private int status = 0;

    // Use this for initialization
    void Start () {
        audio2 = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        if (audio2.isPlaying == false && status == 0)
        {
            audio2.PlayOneShot(background, 0.6f);
            status++;
        } else if (audio2.isPlaying == false && status == 1)
        {
            audio2.PlayOneShot(background2, 0.6f);
            status++;
        } else if (audio2.isPlaying == false && status == 2)
        {
            audio2.PlayOneShot(background3, 0.6f);
            status = 0;
        }
	}
}
