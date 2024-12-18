using UnityEngine;

public class Generator : MonoBehaviour
{
    // при переходе на большие префабы цифры нужно заменить

    public GameObject[] paterns;
    private Vector3 _currentPosition = new Vector3(0,0,25f); // позиция спавна

    void Start()
    {
        DeadMenu.OnStart +=OnStart;
    }

    private void generate(){
        int number   =  Random.Range(0, 4);  // выбор префаба
        Instantiate(paterns[number],_currentPosition, Quaternion.identity);
        
    }

    void OnTriggerEnter(Collider collision){ // для создания последующих препятствий
        if(collision.GetComponent<Collider>().tag == "StartPatern"){ 
        generate();
        }
    }

    void OnStart(){
        DestroyPrefabs();
        generate();
    }

        void DestroyPrefabs(){
        GameObject[] clones = GameObject.FindGameObjectsWithTag("patern");
        
        foreach (GameObject clone in clones)
        {
            Destroy(clone);
        }
    }
}
