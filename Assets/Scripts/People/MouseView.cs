using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseView : MonoBehaviour
{
    [SerializeField]
    GameObject input;

    private float x, y;
    private Transform t;
    private int DPI;
    // Use this for initialization
    void Start()
    {
        t = GetComponent<Transform>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        DPI = 350;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");

        input.transform.Rotate(new Vector3(0, x * DPI * Time.deltaTime, 0));
        t.Rotate(new Vector3(y * -DPI * Time.deltaTime, 0, 0));

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetMouseButtonUp(0))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

}
