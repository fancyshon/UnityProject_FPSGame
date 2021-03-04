using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interect : MonoBehaviour {
    static float HP;
    private Rigidbody r;
    private bool check;
    [SerializeField] Image image;
    // Start is called before the first frame update
    void Start() {
        r = GetComponent<Rigidbody>();
        HP = 100;
        check = true;
    }

    // Update is called once per frame
    void Update() {
        if (image.fillAmount < 100f && check == true) {
            image.fillAmount += 0.005f;
        }

        if (HP <= 0) {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(3);
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void OnCollisionEnter(Collision cc) {
        if (cc.gameObject.tag == "Zombie") {
            HP -= 5f;
            r.AddForce((Vector3.forward + Vector3.up) * 6000);
            image.fillAmount = HP / 100f;
            check = false;
        }
    }

}
