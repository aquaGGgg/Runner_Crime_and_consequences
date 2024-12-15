using UnityEngine;
using System;


public class Trigger_Collision_Controller : MonoBehaviour
{
    public static event Action OnDeath;

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("barer"))
            OnDeath?.Invoke();
    }
}
