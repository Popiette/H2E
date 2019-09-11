using UnityEngine;
using UnityEngine.EventSystems;

//Put the focus on the selected button when clicking with mouse
public class Refocus : MonoBehaviour
{

    GameObject selected;

    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            Debug.Log("Reselecting first input");
            EventSystem.current.SetSelectedGameObject(selected);
        }
        else
        {
            selected = EventSystem.current.currentSelectedGameObject;
        }
    }
}