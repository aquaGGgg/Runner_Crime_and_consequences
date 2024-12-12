using UnityEngine;

public class DogeComponent : MonoBehaviour
{   
    public float jumpForce = 1f;

    private Rigidbody _rb;
    private Animator _anime;
    private BoxCollider _boxCollider;  // Коллайдер персонажа
    private bool _isGrounded;
    private int _poss;

    void Start()
    {
        _boxCollider = GetComponent<BoxCollider>();
        _rb = GetComponent<Rigidbody>();
        _anime = GetComponent<Animator>();
    }


    void Update()
    { 
        if(_isGrounded && _anime.GetBool("isJumping") == true){
            _anime.SetBool("isJumping", false);
        }
        
        if(Input.GetKeyDown(KeyCode.D)){
            if(_poss<1) _poss++;
            transform.position = new Vector3(_poss,transform.position.y, transform.position.z);
        }        
        if(Input.GetKeyDown(KeyCode.A)){
            if(_poss>-1) _poss--;
            transform.position = new Vector3(_poss,transform.position.y, transform.position.z);
        }

        if((Input.GetButton("Jump") || Input.GetKeyDown(KeyCode.W))&& _isGrounded){ //@jump
            _anime.SetBool("isJumping", true);
            _rb.linearVelocity = new Vector3(_rb.linearVelocity.x, CalculateJumpVelocity(), _rb.linearVelocity.z);
           }


        if(Input.GetKeyDown(KeyCode.S) && _isGrounded){ // @slide
        _boxCollider.size = _boxCollider.size * 0.5f;
        _boxCollider.center = _boxCollider.center * 0.5f;
        _anime.SetBool("isSliding", true);
        Invoke("NonSliding", 0.5f);
        }
           
    }


    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("ground"))
            _isGrounded = true;

        if(collision.gameObject.CompareTag("barer"))
        Dead();
    }
    void OnCollisionExit(Collision collision){
        if(collision.gameObject.CompareTag("ground"))
            _isGrounded = false;
    }

    float CalculateJumpVelocity()
    {
        return Mathf.Sqrt(2 * Mathf.Abs(Physics.gravity.y) * jumpForce);
    }


    void Dead(){ // методж должен вызывать экран\меню смерти, паузу лучше прописать в Ui менеджере 
        Destroy(gameObject);
    }


    void NonSliding(){
        _boxCollider.size = _boxCollider.size * 2f;
        _boxCollider.center = _boxCollider.center * 2f;
        _anime.SetBool("isSliding", false);
    }
    // преследование в другом скрипте
}