using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{

    [SerializeField]
    Vector3 moving_vec;    //Private but can be seen in the spector
    //public Camera c;
    private float speed = 8f;
    private Animator a;

    // Use this for initialization
    void Start()
    {
        Transform t = GetComponent<Transform>();
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
        //    a.SetBool("run", true);
        //else
        //    a.SetBool("run", false);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            a.SetBool("run", true);
            speed = 12f;
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(speed * Time.deltaTime * Vector3.forward);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(speed * Time.deltaTime * Vector3.left);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(speed * Time.deltaTime * Vector3.back);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(speed * Time.deltaTime * Vector3.right);
            }
        }
        else
            a.SetBool("run", false);


        if (Input.GetKey(KeyCode.W))
        {
            a.SetBool("walk", true);
            transform.Translate(speed * Time.deltaTime * Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            a.SetBool("walk", true);
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            a.SetBool("walk", true);
            transform.Translate(speed * Time.deltaTime * Vector3.back);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            a.SetBool("walk", true);
            transform.Translate(speed * Time.deltaTime * Vector3.right);
        }
        else
        {
            a.SetBool("walk", false);
            a.SetBool("run", false);
        }
    }

}
