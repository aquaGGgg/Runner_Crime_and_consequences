using UnityEngine;
using UnityEngine.UI;
using TMPro; 


public class allMany : MonoBehaviour
{
    
    public TextMeshProUGUI  text;  

    public static int coins;



    void FixedUpdate(){
        GetMany();
    }

    void GetMany(){
        text.text = "" + coins;
    }
}
