using UnityEngine;

public class DeadMenu : MonoBehaviour
{

    public GameObject deadMenu;

    void Start()
    {
        Trigger_Collision_Controller.OnDeath += genMenu;
    }

    void genMenu(){
        deadMenu.SetActive(true);
    }
}
