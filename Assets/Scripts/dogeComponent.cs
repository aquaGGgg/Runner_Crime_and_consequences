using UnityEngine;

public class dogeComponent : MonoBehaviour
{   
    public float jumpForce = 1f;

    private Rigidbody rb;
    private bool isGrounded;
    public int poss;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.D)){
            if(poss<1) poss++;
            transform.position = new Vector3(poss,transform.position.y, transform.position.z);
        }        
        if(Input.GetKeyDown(KeyCode.A)){
            if(poss>-1) poss--;
            transform.position = new Vector3(poss,transform.position.y, transform.position.z);
        }

        if(Input.GetButton("Jump") && isGrounded)
            rb.AddForce(new Vector3(0f, jumpForce * Time.deltaTime,0f), ForceMode.Impulse);

        if(Input.GetKeyDown(KeyCode.S) && isGrounded){
        transform.localScale = transform.localScale * 0.5f;
        Invoke("ToBigger", 0.5f);
        }
           
    }


    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("ground"))
            isGrounded = true;

        if(collision.gameObject.CompareTag("barer"))
        Dead();
    }
    void OnCollisionExit(Collision collision){
        if(collision.gameObject.CompareTag("ground"))
            isGrounded = false;
    }



    void Dead(){ // методж должен вызывать экран\меню смерти, паузу лучше прописать в Ui менеджере 
        Destroy(gameObject);
    }


    void ToBigger(){
        transform.localScale = transform.localScale * 2f;
    }
    // преследование в другом скрипте
}