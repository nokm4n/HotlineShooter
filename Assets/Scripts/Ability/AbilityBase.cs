using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityBase : MonoBehaviour
{
	protected AttackType AttackType;
	protected AbilityType AbilityType;
	protected AttackRangeType AttackRangeType;
	protected DamageType DamageType;

}
public enum AttackType
{
	OneAttack,
	Autoattack
}

public enum AbilityType
{
	DamageAbility,
	HealAbility
}

public enum AttackRangeType
{
	MeleeAttack,
	RangeAttack,
	Inner
}

public enum DamageType
{
	Magical,
	Physical
}
