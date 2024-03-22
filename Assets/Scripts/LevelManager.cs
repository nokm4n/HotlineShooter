using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private float winDelay = 2f;
    [SerializeField] private float failDelay = 2f;
    [SerializeField] private int acceptAmount = 1;
    
    private int win;
    
    public void Accept()
    {
        win++;
        
        if (win == acceptAmount)
        {
            //Events.LevelEndDelayed.Invoke(true,winDelay);
        }
    }

    public void CancelAccept()
    {
        win--;
    }

    public void Failed()
    {
        //Events.LevelEndDelayed.Invoke(false, failDelay);
    }
}
