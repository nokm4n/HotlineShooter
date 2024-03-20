using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField, NotNull] private Rigidbody2D _rb;
	[SerializeField, NotNull] GameObject _hitEffect;
    [SerializeField] private float force;

	private void Awake()
	{
		_rb.AddForce(transform.up * force, ForceMode2D.Impulse);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		GameObject hitEffect = Instantiate(_hitEffect, transform.position, Quaternion.identity);
		Destroy(hitEffect, 5f);
		Destroy(gameObject);
	}
}
