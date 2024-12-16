using UnityEngine;
using System;


public class Trigger_Collision_Controller : MonoBehaviour
{
    public static event Action OnDeath;
    public static event Action OnMagneting;  
    private bool _isSheald;



    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("barer") && !_isSheald){
            OnDeath?.Invoke();
        }else if(other.gameObject.CompareTag("barer") && _isSheald){
            Destroy(other.gameObject);
            _isSheald = false;
            }


        if (other.gameObject.CompareTag("Shild")){
            Destroy(other.gameObject);
            _isSheald = true;
        }


        if (other.gameObject.CompareTag("Magnet")){
            OnMagneting?.Invoke(); 
            Destroy(other.gameObject);
        }
    }

}






