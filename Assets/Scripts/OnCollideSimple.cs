using UnityEngine;
using UnityEngine.Events;

public class OnCollideSimple : MonoBehaviour
{
    [SerializeField] protected UnityEvent TriggerEvent;
    [SerializeField] protected UnityEvent ExitTrigger;
    [SerializeField] protected AudioClip clip;
    [SerializeField] protected string CollideName;
    [SerializeField] protected bool disableCollide = false;

    public void SubEvent(UnityAction action)
    {
        TriggerEvent.AddListener(action);
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (!string.IsNullOrEmpty(CollideName) && collision.name == CollideName)
        {
            if(clip != null) 
			    AudioManager.Instance.PlayOneShot(clip);

			TriggerEvent?.Invoke();

            if (disableCollide)
            {
                collision.gameObject.SetActive(false);
            }
        }
        else if (string.IsNullOrEmpty(CollideName))
        {

            TriggerEvent?.Invoke();

            if (disableCollide)
            {
                collision.gameObject.SetActive(false);
            }
        }
    }

    protected virtual void OnTriggerExit2D(Collider2D collision)
    {
        if (!string.IsNullOrEmpty(CollideName) && collision.name == CollideName)
        {

            ExitTrigger?.Invoke();

            if (disableCollide)
            {
                collision.gameObject.SetActive(false);
            }
        }
        else if (string.IsNullOrEmpty(CollideName))
        {

            ExitTrigger?.Invoke();

            if (disableCollide)
            {
                collision.gameObject.SetActive(false);
            }
        }
    }

    public void EnableComponentAndCollider()
    { 
        GetComponent<Collider2D>().enabled = true;
        enabled = true;
    }

    public void DisableComponentAndCollider()
    { 
        GetComponent<Collider2D>().enabled = false;
        enabled = false;
    }

    public void DelComponent()
    { 
        Destroy(this);
    }
}
