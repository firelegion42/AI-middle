using UnityEngine;

public class PlayerMove : MonoBehaviour, IMoveable
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private Animator animator;

    private Vector2 _moveInput;
    private Rigidbody rb;
    private float _rotationSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        _rotationSpeed = 10;
    }

    public void Move(Vector2 input)
    {
        _moveInput = input;
    }

    private void Update()
    {
        animator.SetBool("IsRunning", _moveInput.sqrMagnitude > 0.1f);
        rb.linearVelocity = new Vector3(_moveInput.x * _movementSpeed, rb.linearVelocity.y, _moveInput.y * _movementSpeed);

        Vector3 lookDirection = new Vector3(_moveInput.x, 0, _moveInput.y);
        if(lookDirection.sqrMagnitude > 0.01f)
        {
            Quaternion target = Quaternion.LookRotation(lookDirection);
            rb.MoveRotation(Quaternion.Slerp(rb.rotation, target, _rotationSpeed * Time.deltaTime));
        } 
    }
   
}
