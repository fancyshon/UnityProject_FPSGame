using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Count_time : MonoBehaviour {
    [SerializeField]
    GameObject Zombie;
    [SerializeField]
    GameObject Generate_point1;
    [SerializeField]
    GameObject Generate_point2;
    [SerializeField]
    GameObject Generate_point3;
    [SerializeField]
    GameObject Generate_point4;
    [SerializeField]
    GameObject Generate_point5;
    [SerializeField]
    GameObject Generate_point6;
    [SerializeField]
    GameObject Generate_point7;
    [SerializeField]
    GameObject Generate_point8;
    [SerializeField]
    GameObject Generate_point9;
    [SerializeField]
    GameObject Generate_point10;
    [SerializeField]
    GameObject Generate_point11;
    [SerializeField]
    GameObject Generate_point12;
    [SerializeField]
    GameObject Generate_point13;
    [SerializeField]
    GameObject Generate_point14;
    [SerializeField]
    GameObject Generate_point15;
    [SerializeField]
    GameObject Generate_point16;
    [SerializeField]
    GameObject Generate_point17;
    int sec;
    int time_remain;
    int time_survive;
    float starttime;
    float timecounter;
    bool generate = false;
    bool safe = false;
    [SerializeField]
    Text text;

    // Start is called before the first frame update
    void Start() {
        starttime = Time.time;
        //text = GetComponent<Text>();
        time_remain = 10;
        time_survive = 59;
    }

    // Update is called once per frame
    void Update() {
        timecounter = Time.time - starttime;
        sec = (int)(timecounter % 60f);
        time_remain =10- sec;
        if (time_remain >= 0) {
            text.text = "逃跑時間 " + time_remain;
        }
        else if(time_survive>=0){
            time_survive = 59 - sec;
            text.text = "獲救時間 " + time_survive;
            if (time_survive == 0) {
                SceneManager.LoadScene(5);
                SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
                Cursor.lockState = CursorLockMode.None;
            }
        }

        if (time_remain == 0) {
            if (generate == false) {
                for (int i = 0; i < 4; i++) {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point1.transform.position;
                }
                for (int i = 0; i < 4; i++) {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point2.transform.position;
                }
                for (int i = 0; i < 4; i++) {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point3.transform.position;
                }
                for (int i = 0; i < 4; i++) {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point4.transform.position;
                }
                for (int i = 0; i < 4; i++) {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point5.transform.position;
                }
                for (int i = 0; i < 4; i++)
                {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point6.transform.position;
                }
                for (int i = 0; i < 4; i++)
                {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point7.transform.position;
                }
                for (int i = 0; i < 4; i++)
                {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point8.transform.position;
                }
                for (int i = 0; i < 4; i++)
                {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point9.transform.position;
                }
                for (int i = 0; i < 4; i++)
                {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point10.transform.position;
                }
                for (int i = 0; i < 4; i++)
                {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point11.transform.position;
                }
                for (int i = 0; i < 4; i++)
                {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point12.transform.position;
                }
                for (int i = 0; i < 4; i++)
                {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point13.transform.position;
                }
                for (int i = 0; i < 4; i++)
                {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point14.transform.position;
                }
                for (int i = 0; i < 4; i++)
                {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point15.transform.position;
                }
                for (int i = 0; i < 4; i++)
                {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point16.transform.position;
                }
                for (int i = 0; i < 4; i++)
                {
                    GameObject new_zombie = Instantiate(Zombie);
                    new_zombie.SetActive(true);
                    new_zombie.transform.position = Generate_point17.transform.position;
                }
                generate = true;
            }

        }
       
    }
}
