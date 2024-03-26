using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
	[SerializeField, NotNull] private GameObject _main;
	[SerializeField, NotNull] private GameObject _play;
	[SerializeField, NotNull] private GameObject _options;

	private void Awake()
	{
		OnMain();
	}

	public void OnMain()
	{
		_main.transform.DOScale(Vector3.one, 0.2f);
		_play.transform.DOScale(Vector3.zero, 0);
		_options.transform.DOScale(Vector3.zero, 0);
	}

	public void OnPlay()
	{
		_main.transform.DOScale(Vector3.zero, 0);
		_play.transform.DOScale(Vector3.one, 0.2f);
		_options.transform.DOScale(Vector3.zero, 0);
	}

	public void OnOptions()
	{
		_main.transform.DOScale(Vector3.zero, 0);
		_play.transform.DOScale(Vector3.zero, 0);
		_options.transform.DOScale(Vector3.one, 0.2f);
	}

	public void OnExit()
	{
		Application.Quit();
	}
}
