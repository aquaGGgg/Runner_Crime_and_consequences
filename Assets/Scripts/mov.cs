using UnityEngine;

public class Mov : MonoBehaviour
{

   public Transform target; 

   public static float speed = 3.5f;

    void Update()
    {
        if (target == null) return;

        Vector3 direction = (target.position - transform.position).normalized; 
        transform.position += direction * speed * Time.deltaTime; 

        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            transform.position = target.position; 
            bustMovspead();
            Destroy(gameObject); 
        }

    }

    private void bustMovspead(){ // ускорение после каждого пройденого префаба
        speed +=0.1f;
    }
    
}
