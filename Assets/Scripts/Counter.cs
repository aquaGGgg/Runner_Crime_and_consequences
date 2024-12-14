using UnityEngine;
using UnityEngine.UI;
using TMPro; 


public  class Counter : MonoBehaviour
{
    public TextMeshProUGUI  text; 

    private float _counter;


    void Update()
    {
        _counter+=1 * Time.deltaTime* multiplication();

        if(text != null)
        text.text= "" + (int) _counter;
    }

    float multiplication(){
        return Time.time / 2;
    }
}
