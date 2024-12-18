using UnityEngine;
using UnityEngine.UI;
using TMPro; 


public  class Counter : MonoBehaviour
{
    public TextMeshProUGUI  text; 

    private float _counter;
    private float _mytime;

    void Start(){

        DeadMenu.OnStart +=OnStart;
    }

    void Update()
    {
        _mytime+=Time.deltaTime;
        _counter+=1 * Time.deltaTime* multiplication();

        if(text != null)
        text.text= "" + (int) _counter;
    }

    float multiplication(){
        return  _mytime/ 2;
    }

    void OnStart(){
        _counter = 0;
        _mytime = 0;
    }
}
