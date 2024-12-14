using UnityEngine;

public class RandomCoinTransform : MonoBehaviour
{

    public GameObject[] buffes;
    void Start()
    {
        int number   =  Random.Range(0, 10); 
        GameObject spawnedBuff = Instantiate(buffes[number], transform.position, Quaternion.identity);

        spawnedBuff.transform.SetParent(transform);
    }
}
 