using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator _bodyAnimator;
    [SerializeField] private Animator _legAnimator;

    public void SetSpeed(float value)
    {
        _bodyAnimator.SetFloat("Speed", value);
        _legAnimator.SetFloat("Speed", value);
    }

    public void SetWeapon(int weaponId)
    {
        _bodyAnimator.SetInteger("Weapon", weaponId);
    }
}
