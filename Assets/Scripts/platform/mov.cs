using UnityEngine;

public class Mov : MonoBehaviour
{

   public Transform target;
   [SerializeField]
   private static float _speed = 3f;

    void Update()
    {
        if (target == null) return;

        Vector3 direction = (target.position - transform.position).normalized; 
        transform.position += direction * _speed * Time.deltaTime; 

        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            transform.position = target.position; 
            bustMovspead();
            Destroy(gameObject); 
        }

    }

    private void bustMovspead(){ // ускорение после каждого пройденого препятствия
        _speed += 0.01f;
    }
    
}
