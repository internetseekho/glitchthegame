using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log( "Name of object is " + name);
    }

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
	}

    private void OnLevelWasLoaded(int level)
    {
        Debug.Log( levelMusicChangeArray[level] );
        if (levelMusicChangeArray[level]) {
            audioSource.clip = levelMusicChangeArray[level];
            audioSource.loop = true;
            audioSource.Play();
        }

    }

    public void SetVolume(float volume) {
        audioSource.volume = volume;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
