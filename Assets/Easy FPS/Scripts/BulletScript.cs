using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

    [Tooltip("Furthest distance bullet will look for target")]
    public float maxDistance = 5000;
    [Tooltip("Prefab of wall damange hit. The object needs 'LevelPart' tag to create decal on it.")]
    public GameObject decalHitWall;
    [Tooltip("Decal will need to be sligtly infront of the wall so it doesnt cause rendeing problems so for best feel put from 0.01-0.1.")]
    public float floatInfrontOfWall;
    [Tooltip("Blood prefab particle this bullet will create upoon hitting enemy")]
    public GameObject bloodEffect;
    [Tooltip("Put Weapon layer and Player layer to ignore bullet raycast.")]
    public LayerMask ignoreLayer;

    /*
	* Uppon bullet creation with this script attatched,
	* bullet creates a raycast which searches for corresponding tags.
	* If raycast finds somethig it will create a decal of corresponding tag.
	*/


    void Update() {
        RaycastHit hit;
        RaycastHit Z;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, maxDistance)) {
            if (decalHitWall) {
                if (hit.transform.tag == "LevelPart") {
                    Instantiate(decalHitWall, hit.point + hit.normal * floatInfrontOfWall, Quaternion.LookRotation(hit.normal));
                    Destroy(gameObject);
                }
                if (hit.transform.tag == "Dummie") {
                    Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(gameObject);
                }
            }
            if (hit.transform.tag == "Zombie") {
                Debug.Log("HIT");
                hit.transform.GetComponentInParent<Hit_Zombie>().Hit();
                End_point.damage_point += 30;
            }
            Destroy(gameObject);
        }
        Destroy(gameObject, 0.1f);

        
        //if (Physics.Raycast(ray, out Z, maxDistance)) {
        //    if (Z.transform.tag == "Zombie") {
        //        Debug.Log("HIT2");
        //        Z.transform.GetComponentInParent<Hit_Zombie>().Hit();
        //        End_point.damage_point += 30;
        //    }
        //}
    }
}
