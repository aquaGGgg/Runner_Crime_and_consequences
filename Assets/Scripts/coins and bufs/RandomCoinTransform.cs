using UnityEngine;

public class RandomCoinTransform : MonoBehaviour
{

    public GameObject[] buffes;
    private GameObject spawnedBuff;
    void Start()
    {
        int number   =  Random.Range(0, 100);

        if (number <= 90)
        {
            spawnedBuff = Instantiate(buffes[0], transform.position, Quaternion.identity);
        }
        else if (number > 90 && number <= 95)
        {
            spawnedBuff = Instantiate(buffes[1], transform.position, Quaternion.identity);
        }
        else if (number > 95)
        {
            spawnedBuff = Instantiate(buffes[2], transform.position, Quaternion.identity);
        }
        
        spawnedBuff.transform.SetParent(transform);
    }
}
 