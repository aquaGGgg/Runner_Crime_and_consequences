using UnityEngine;
using UnityEngine.UI;
using TMPro; 
using System;

public class DeadMenu : MonoBehaviour
{    

    public GameObject deadMenu;

    public static event Action OnStart;
    public static event Action GoToMenu;

    public TextMeshProUGUI[] counters; 
    public TextMeshProUGUI allMoney; 
    public GameObject countersOjg;
    public GameObject mainMenu;
     


    void Start()
    {
        Trigger_Collision_Controller.OnDeath += genMenu;
        MainMenu.OnPlay += RestartGame;
    }

    void genMenu(){
        deadMenu.SetActive(true);
    }

    public void RestartGame(){ 
        OnStart?.Invoke();
        RestartCounters();

        deadMenu.SetActive(false);
        Time.timeScale = 1;
    }

    void RestartCounters(){
        counters[0].text = "0";
        counters[1].text = "0";
    }

    public void ToMainMenu(){
        GoToMenu?.Invoke();
        countersOjg.SetActive(false);
        mainMenu.SetActive(true);
        deadMenu.SetActive(false);
    }
}
