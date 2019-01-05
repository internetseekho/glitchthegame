using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider, diffSlider;
    public LevelManager levelManager;
    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        //PlayerPrefs.DeleteAll();
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        diffSlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () {
        musicManager.SetVolume(volumeSlider.value);
	}

    public void SaveandExit() {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetDifficulty(diffSlider.value);
        levelManager.LoadLevel("01 a Start");
    }

    public void SetDefaults() {
        PlayerPrefsManager.SetMasterVolume(0.2f);
        PlayerPrefsManager.SetDifficulty(2f);
        levelManager.LoadLevel("01 b Options");
    }

}
