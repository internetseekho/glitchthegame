using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_UNLOCKED_KEY = "level_unlock_";
    // level_unlock_03

    public static void SetMasterVolume(float volume) {
        if (volume >= 0 && volume <= 1)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }else {
            Debug.LogError("Volume Out of range");
        }
    }

    public static float GetMasterVolume() {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void UnlockLevel(int level)
    {
        if (level <= Application.levelCount - 1)
        {
            // level_unlock_3
            PlayerPrefs.SetInt(LEVEL_UNLOCKED_KEY + level.ToString(), 1);
        } else {
            Debug.LogError("Level entered is not in build order");
        }
    }

    public static bool IsLevelUnlock(int level)
    {

        int levelValue = PlayerPrefs.GetInt(LEVEL_UNLOCKED_KEY + level.ToString());
        bool isUnlocked = (levelValue == 1);

        if (level <= Application.levelCount - 1)
        {
            return isUnlocked;
        }
        else
        {
            Debug.LogError("Level quried is not in build order");
            return false;
        }
    }

    public static void SetDifficulty( float diff ) {
        // 1 easy 2 medium and 3 hard
        if (diff >= 1f && diff <= 3f) {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, diff);
        } else {
            Debug.LogError("Value of difficulty is not in range");
        }
    }

    public static float GetDifficulty() {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }

}
