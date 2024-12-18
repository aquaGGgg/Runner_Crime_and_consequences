using UnityEngine;

public class RandomCoinTransform : MonoBehaviour
{

    public GameObject[] buffes;
    private GameObject spawnedBuff;
    void Start()
    {
        int number   =  Random.Range(0, 100);

        if (number <= 96)
        {
            spawnedBuff = Instantiate(buffes[0], transform.position, Quaternion.identity);
        }
        else if (number > 96 && number <= 98)
        {
            spawnedBuff = Instantiate(buffes[1], transform.position, Quaternion.identity);
        }
        else if (number > 98)
        {
            spawnedBuff = Instantiate(buffes[2], transform.position, Quaternion.identity);
        }
        
        spawnedBuff.transform.SetParent(transform);
    }
}
 