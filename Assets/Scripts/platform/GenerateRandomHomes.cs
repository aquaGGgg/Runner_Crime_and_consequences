using UnityEngine;

public class GenerateRandomHomes : MonoBehaviour
{
    public GameObject[] homes;

    void Start()
    {
        generate();
    }


    void Update()
    {
        
    }

    private void generate(){
        int number   =  Random.Range(0, homes.Length - 1);  // выбор префаба
        Instantiate(homes[number], transform.position, Quaternion.identity);
        transform.SetParent(transform);
    }
}
