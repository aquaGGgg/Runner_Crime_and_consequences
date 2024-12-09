using UnityEngine;

public class mov : MonoBehaviour
{

   public Transform target; 
   public static float speed = 5f;
   bool isbufspeed =false;

    void Update()
    {
        if (target == null) return;

        Vector3 direction = (target.position - transform.position).normalized; 
        transform.position += direction * speed * Time.deltaTime; 

        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            transform.position = target.position; 
            isbufspeed = true;
            Destroy(gameObject); 
        }

        if(isbufspeed ==true) bustMovspead();
    }

    private void bustMovspead(){ // ускорение после каждого пройденого префаба
        speed +=0.1f;
        isbufspeed =false;
    }
    
}
