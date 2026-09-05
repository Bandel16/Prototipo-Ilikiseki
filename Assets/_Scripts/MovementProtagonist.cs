using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class MovementProtagonist : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 playermovement;
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

   
    void FixedUpdate()
    {
            rigidbody.linearVelocity = playermovement * speed;
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector3 move = context.ReadValue<Vector3>();
        playermovement = move;

    }
}
