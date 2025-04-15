using UnityEngine;
using UnityEngine.Rendering;

public class Fireball : MonoBehaviour
{
    public Rigidbody fireballRB;
    public float speed = 5;
    public float destroyTimer = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fireballRB.linearVelocity = transform.forward * speed;
        Destroy(gameObject, destroyTimer);
    }
}
