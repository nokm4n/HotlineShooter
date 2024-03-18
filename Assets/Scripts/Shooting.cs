using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField, NotNull] private Transform _firePoint;
    [SerializeField, NotNull] private Bullet _bullet;

	private void Update()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}
	}

	public void Shoot()
    {
        Bullet bullet = Instantiate(_bullet, _firePoint.position, _firePoint.rotation);
		//bullet._rb.AddForce(_firePoint.up * bullet.force, ForceMode2D.Impulse);
	}
}
