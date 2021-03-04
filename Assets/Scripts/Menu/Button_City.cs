using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Button_City : MonoBehaviour, IPointerClickHandler {

    public void OnPointerClick(PointerEventData e) {
        //Get current scene
        SceneManager.LoadScene(1);
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

    // Use this for initialization
    void Start() {
        Cursor.visible = true;
        if (SceneManager.GetActiveScene().buildIndex == 0) {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
