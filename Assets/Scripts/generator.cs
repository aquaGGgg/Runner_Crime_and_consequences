using UnityEngine;

public class generator : MonoBehaviour
{

    public GameObject[] paterns;
    
    void Start()
    {
        generate(5); // стартавая генерация
    }

    void Update()
    {
        
    }

    private void generate(int count){
        Vector3 currentPosition = transform.position - new Vector3(0,1,-4);
        
        for(int i =0; i<count;i++){
        int number   =  Random.Range(0, 4);
        Instantiate(paterns[number],currentPosition, Quaternion.identity);
        currentPosition += Vector3.forward * 4;
        }
    }
}
