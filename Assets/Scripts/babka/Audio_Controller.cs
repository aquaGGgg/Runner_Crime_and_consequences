using UnityEngine;

public class Audio_Controller : MonoBehaviour
{
    
    public AudioClip[] songs;
    private AudioSource songcontroller;
    public AudioSource mainMusic;

    void Start()
    {
        songcontroller = GetComponent<AudioSource>();

        Trigger_Collision_Controller.OnDeath += Dead;
        Trigger_Collision_Controller.OnTakeCoin +=Coin;
    }

    void Dead(){
        songcontroller.clip = songs[0];
        songcontroller.Play();
        mainMusic.Stop();
    }

    void Coin(){
        songcontroller.clip = songs[1];
        songcontroller.Play();
    }
}
