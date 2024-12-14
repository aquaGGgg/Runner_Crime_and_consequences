using UnityEngine;
using UnityEngine.UI;
using TMPro; 


public  class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI  text; 

    private int _counter = 0;

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("coin")){
            _counter++;
            Destroy(other.gameObject);
            if(text != null)
            text.text= "" + _counter;
        }
    }
}