using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]private float speed = 500;

    private Vector3 Dir;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        transform.Rotate(speed * Time.deltaTime*2,0, speed * Time.deltaTime);

    }

    private void Random()
    {
        
    }
}
