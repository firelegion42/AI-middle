using UnityEngine;

public class PlayerJump : MonoBehaviour, IJumpable 
{
   
    [SerializeField] private int _jumpForce;
    [SerializeField] private LayerMask _groundMask;

    private Rigidbody rb;
    private bool _isGrounded;


    private void Start()
    {
        rb =  GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _isGrounded = Physics.CheckSphere(transform.position, 1.2f, _groundMask);
    }
    public void Jump()
    {
        if (_isGrounded)
        {
            rb.AddForce(new Vector3(0, _jumpForce, 0));
        }
    }
}
