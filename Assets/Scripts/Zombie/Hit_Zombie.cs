using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit_Zombie : MonoBehaviour {
    private float HP;
    [SerializeField] Image image;
    [SerializeField] Image HPbar;
    private Animator a;
    private BoxCollider b;
    private Rigidbody r;
    // Start is called before the first frame update
    void Start() {
        HP = 100f;
        b = GetComponent<BoxCollider>();
        a = GetComponent<Animator>();
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        image.fillAmount = HP / 100;


        if (HP <= 0) {
            a.SetBool("IsDead", true);
            a.SetBool("IsRun", false);
            a.SetBool("IsAttack", false);
            r.isKinematic = true;
            b.enabled = false;
            HPbar.enabled = false;
            this.tag = "Untagged";
        }
    }

    public  void Hit() {
        HP -= 30;
    }

    //void OnCollisionEnter(Collision cc) {
    //    if (cc.transform.tag == "Bullet") {
    //        Debug.Log(123);
    //    }
    //}

}
