using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class WaitTimeAndCallback : MonoBehaviour
{
    [SerializeField] private bool _waitOnStart;
    [SerializeField] private float _waitTime;
    [SerializeField] private UnityEvent _callback;
    
    private bool _waitedNow;
    private IEnumerator _waitTimeRoutine;

    private void Start()
    {
        if (_waitOnStart)
        {
            Wait();
        }
    }

    public void Wait()
    {
        if (!enabled || !gameObject.activeInHierarchy || _waitedNow)
            return;

        _waitTimeRoutine = WaitTime();
        StartCoroutine(_waitTimeRoutine);
    }

    public void StopWait()
    {
        if (_waitTimeRoutine != null) 
            StopCoroutine(_waitTimeRoutine);
    }

    private IEnumerator WaitTime()
    {
        _waitedNow = true;
        
        yield return new WaitForSeconds(_waitTime);

        _waitedNow = false;
        _callback?.Invoke();
    }
}