using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, NotNull] private Rigidbody2D _rb;
    [SerializeField] private float _speed;

    private Camera _camera;
    private Vector2 _movement;
    private Vector2 _mousePos;

	private void Start()
	{
        _camera = Camera.main;
	}

	void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");

        _mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = _mousePos - _rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        _rb.rotation = angle;
        _rb.MovePosition(_rb.position + _movement * _speed * Time.deltaTime);
    }
}
