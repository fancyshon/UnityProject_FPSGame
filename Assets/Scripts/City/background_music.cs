using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class background_music : MonoBehaviour
{
    [SerializeField]
    AudioClip first_music;
    [SerializeField]
    AudioClip music;
    int sec;
    int time_remain;
    int time_survive;
    float starttime;
    float timecounter;
    AudioSource bgm;
    // Start is called before the first frame update
    void Start()
    {
        starttime = Time.time;
        time_remain = 5;
        time_survive = 0;
        bgm = GetComponent<AudioSource>();
        bgm.clip = first_music;
        bgm.Play();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        timecounter = Time.time - starttime;
        sec = (int)(timecounter % 60f);
        time_remain = 10 - sec;
        if(time_remain == 0)
        {
            bgm.clip = music;
            bgm.Play();
        }
    }
}
