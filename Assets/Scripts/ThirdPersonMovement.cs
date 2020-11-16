using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;  // connects to avatar's controller
    public Transform cam; // connects to 3rd person camera

    public float speed = 6f; // default speed, but can be changed in unity

    public float turnSmoothTime = 0.1f; // rotation speed
    float turnSmoothVelocity;

    void Start() {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f) // if the character is moving 
        {
            // this code makes the avatar move in the direction the camera is pointing so
            // moving 'forward' is relative to the avatar instead of unity's axies

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
    }
}
