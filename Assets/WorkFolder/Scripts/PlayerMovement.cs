using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 _currentVelocity;
    private Rigidbody _controller;
    private bool _canMove = true;

    private void Awake()
    {
        _controller = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_canMove)
        {
            _controller.linearVelocity = _currentVelocity * speed;
        
            Vector3 mousePos = Mouse.current.position.ReadValue();
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            Vector3 hit = ray.GetPoint(9999f);
            hit.y = transform.position.y;
            Vector3 dir = (hit - transform.position).normalized;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 10f * Time.deltaTime);
        }
    }

    private void OnMove(InputValue value)
    {
        Vector3 velo = value.Get<Vector2>();
        _currentVelocity = new Vector3(velo.x, _controller.linearVelocity.y, velo.y);
    }

    public void Stop()
    {
        _canMove = false;
    }

    public void ResumeMove()
    {
        _canMove = true;
    }

    public void AddForce(Vector3 force, ForceMode mode = ForceMode.Impulse)
    {
        transform.DOMove( transform.position+force,0.5f).SetEase(Ease.InBack);
    }
}
