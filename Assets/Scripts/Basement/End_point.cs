using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class End_point : MonoBehaviour
{
    [SerializeField]
    Text txt;
    [SerializeField]
    Text damage;
    int sec;
    static public int damage_point ;
    float starttime;
    float timecounter;
    bool win;

    // Start is called before the first frame update
    void Start()
    {
        win = false;
        damage_point = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (win == true)
        {
            timecounter = Time.time - starttime;
            sec = (int)(timecounter % 60f);
            if(sec == 3)
            {
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene(4);
                SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.transform.name == "Player")
        {
            starttime = Time.time;
            txt.enabled = true;
            win = true;
            txt.text = "You WIn!!!!";
            //damage.text = "Your danage is " + damage_point;
            Cursor.visible = true;
        }
    }
}
