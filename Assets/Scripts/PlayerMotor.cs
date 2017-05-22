using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController contriller;
    private Vector3 moveVector;

    
    private float animationDuration = 2.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 10.0f;
    private float speed = 2.0f;

    void Start()
    {
        contriller = GetComponent<CharacterController>();

    }

    void Update()
    {
        if (Time.time < animationDuration)
        {
            contriller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }
        moveVector = Vector3.zero;

        if (contriller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        // X - Left and Right
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        // Y - Up and Down
        moveVector.y = verticalVelocity;
        // Z - Forward and Backward
        moveVector.z = speed;


        contriller.Move(moveVector * speed * Time.deltaTime);
    }

}
