using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace hydroger.menu
{

    // Actions that can be triggered by using menu options.
    public class MenuInteractions : MonoBehaviour
    {

        public void NouvellePartie()
        {
            // Replace 0 by level ID (to do when scenes will exists)
            SceneManager.LoadScene(0);
        }

        public void Continuer()
        {
            // TODO: replace hardcoded value by currentLevel variable.
            // (when the scenes will exists)
            SceneManager.LoadScene(0);
        }


        public void ChoixduNiveau()
        {
            // TODO: change selectable levels according to max level.
        }


        public void Options()
        {
            // TODO: Implement options.
        }


        public void Quitter()
        {
            Debug.Log("Quit");
            Application.Quit();
        }


    }

}
