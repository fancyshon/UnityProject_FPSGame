using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Zombie : MonoBehaviour
{
    [SerializeField]
    GameObject People;

    private bool deteced;
    private Vector3 target;
    private Vector3 target_dir;
    private float speed;
    private float now_rotation_y;
    Rigidbody r;
    private Animator a;
    
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 2f;
        deteced = false;
        r = GetComponent<Rigidbody>();
        a = GetComponent<Animator>();
        r.constraints = RigidbodyConstraints.FreezeRotationX;
        r.constraints = RigidbodyConstraints.FreezeRotationZ;
        a.SetBool("IsDead", false);


    }

    // Update is called once per frame
    void Update()
    {
        if (a.GetBool("IsDead") == false)
        {
            if (deteced)
            {
                transform.position = new Vector3(Vector3.MoveTowards(transform.position, People.transform.position, speed * Time.deltaTime).x, transform.position.y, Vector3.MoveTowards(transform.position, People.transform.position, speed * Time.deltaTime).z);
                Vector3 v3 = new Vector3(People.transform.position.x, People.transform.position.y - 0.97f, People.transform.position.z);
                Vector3 newDir = Vector3.RotateTowards(transform.forward, v3 - transform.position, 2f * Time.deltaTime, 0.0f);
                transform.rotation = Quaternion.LookRotation(newDir);
                a.SetBool("IsRun", true);
            }
            else
            {
                //transform.rotation = Quaternion.Euler(0f, transform.rotation.y, 0f);
                //transform.LookAt(People.transform);
                r.constraints = RigidbodyConstraints.FreezeRotationX;
                r.constraints = RigidbodyConstraints.FreezeRotationZ;
                Vector3 v3 = new Vector3(People.transform.position.x, People.transform.position.y - 0.97f, People.transform.position.z);
                Vector3 newDir = Vector3.RotateTowards(transform.forward, v3 - transform.position, 2f * Time.deltaTime, 0.0f);
                transform.rotation = Quaternion.LookRotation(newDir);

                a.SetBool("IsRun", false);
            }
        }
    }


    void OnTriggerEnter(Collider c)
    {
        if(c.transform.name == "Player")
        {
            deteced = true;
        }
    }

    void OnTriggerExit(Collider c)
    {
        if(c.transform.name == "Player")
        {
            deteced = false;
        }
    }

    void OnCollisionStay(Collision c)
    {
        if(c.transform.name == "Player")
        {
            deteced = false;
            a.SetBool("IsAttack", true);
        }
    }

    void OnCollisionExit(Collision c)
    {
        if (c.transform.name == "Player")
        {
            deteced = true;
            a.SetBool("IsAttack", false);
        }
    }


}
