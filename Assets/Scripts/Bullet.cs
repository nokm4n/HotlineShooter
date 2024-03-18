using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField, NotNull] private Rigidbody2D _rb;
    [SerializeField] private float force;

	private void Awake()
	{
		_rb.AddForce(transform.up * force, ForceMode2D.Impulse);
	}
}
