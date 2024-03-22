using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class CEvents : MonoBehaviour
{
	public static event Action OnEvent;
	public static void FireEvent() => OnEvent?.Invoke();
}
