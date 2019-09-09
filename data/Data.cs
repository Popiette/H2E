using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace hydroger.data
{

    //Donnees du jeu (chargé au demarrage depuis le fichier data.hr)
    public class Data : MonoBehaviour
    {

        public int currentLevel = 1;
        public int maxLevel = 1;
        public float soundVolume = 0.5f;
        public float musicVolume = 0.5f;

        void Start()
        {
            Load();
        }

        public void Save()
        {
            SaveSystem.Save(this);
        }

        public void Load()
        {
            GameData gameData = SaveSystem.Load();
            if (gameData != null)
            {
                currentLevel = gameData.currentLevel;
                maxLevel = gameData.maxLevel;
                soundVolume = gameData.soundVolume;
                musicVolume = gameData.musicVolume;
            }
        }
    }

}
