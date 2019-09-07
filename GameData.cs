using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe serialisable pour la sauvegarde des données

[System.Serializable]
public class GameData
{

    public int currentLevel;
    public int maxLevel;
    public float soundVolume;
    public float musicVolume;

    public GameData(Data data)
    {
        currentLevel = data.currentLevel;
        maxLevel = data.maxLevel;
        soundVolume = data.soundVolume;
        musicVolume = data.musicVolume;
    }
}
