using UnityEngine;

public class Collision
{
    void onTriggerEnter(Collider other){
        if (other.gameObject.tag == "cherry"){
            Debug.Log("Enter");
        }
    }
}
