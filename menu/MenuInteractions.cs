using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace hydroger.menu
{

    //Effectue differentes actions en fonction du bouton sur lequel on clique dans le menu
    public class MenuInteractions : MonoBehaviour
    {

        public void NouvellePartie()
        {
            SceneManager.LoadScene(0); //il faudra remplacer le 0 par l'indice du niveau 1 (!!!faire le remplacement lorsque les scenes existeront!!!)
        }

        public void Continuer()
        {
            SceneManager.LoadScene(0); //il faudra remplacer par la variable currentLevel de l'objet data (!!!faire le remplacement lorsque les scenes existeront!!!)
        }


        public void ChoixduNiveau()
        {
            //Il faudra changer les niveaux selectionnable en fonction du niveau max
        }


        public void Options()
        {
            //Rien a faire pour l'instant
        }


        public void Quitter()
        {
            Debug.Log("Quit");
            Application.Quit();
        }


    }

}
