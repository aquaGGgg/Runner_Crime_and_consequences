using UnityEngine;
using UnityEngine.UI;
using TMPro; 
using System;

public class DeadMenu : MonoBehaviour
{    

    public GameObject deadMenu;

    public static event Action OnStart;
    public TextMeshProUGUI[] counters; 

     


    void Start()
    {
        Trigger_Collision_Controller.OnDeath += genMenu;
    }

    void genMenu(){
        deadMenu.SetActive(true);
    }

    public void RestartGame(){
        RestartCounters();
        OnStart?.Invoke();


        deadMenu.SetActive(false);
        Time.timeScale = 1;
    }

    void RestartCounters(){
        counters[0].text = "0";
        counters[1].text = "0";
    }
}
