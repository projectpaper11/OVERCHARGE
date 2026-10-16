using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 _currentVelocity;
    private CharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        _controller.Move(_currentVelocity * (speed * Time.deltaTime));
        
        Vector3 mousePos = Mouse.current.position.ReadValue();
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        Vector3 hit = ray.GetPoint(9999f);
        hit.y = transform.position.y;
        Vector3 dir = (hit - transform.position).normalized;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 10f * Time.deltaTime);
    }

    private void OnMove(InputValue value)
    {
        Vector3 velo = value.Get<Vector2>();
        _currentVelocity = new Vector3(velo.x, _controller.velocity.y, velo.y);
    }
}
