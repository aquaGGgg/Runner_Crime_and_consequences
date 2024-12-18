using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject babka;

    void Start()
    {
        RestartGame();
        babka.transform.position = new Vector3(0,-0.4f,-3.58f);
    }

    public void RestartGame()
    {
        GameObject[] clones = GameObject.FindGameObjectsWithTag("ClonedObject");
        
        foreach (GameObject clone in clones)
        {
            Destroy(clone);
        }
    }
}
