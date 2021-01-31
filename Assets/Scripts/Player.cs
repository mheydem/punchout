using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.J)) {
			FightManager.singleton.StartPlayerAnimation (
				"LeftPunch");
		}
		if (Input.GetKey (KeyCode.U)) {
			FightManager.singleton.StartPlayerAnimation (
				"LeftUpPunch");
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			FightManager.singleton.StartPlayerAnimation (
				"RightPunch");
		}
		if (Input.GetKey (KeyCode.O)) {
			FightManager.singleton.StartPlayerAnimation (
				"RightUpPunch");
		}
		if (Input.GetKey (KeyCode.I)) {
			FightManager.singleton.StartPlayerAnimation (
				"UltimateHiperXtremePunch");
		}
		if (Input.GetKeyDown (KeyCode.W)) {

			FightManager.singleton.playerDodge = true;
			FightManager.singleton.animPlayer.SetBool ("Dodge", true);
			FightManager.singleton.StartPlayerAnimation (
				"IdleDodge");
		}
		if (Input.GetKeyUp (KeyCode.W)) {

			FightManager.singleton.playerDodge = false;
			FightManager.singleton.animPlayer.SetBool ("Dodge", false);
		}
		
		if (Input.GetKeyDown (KeyCode.Q)) {
			FightManager.singleton.playerDodge = true;
			Invoke ("SetDodgeFalse", 0.5f);
			FightManager.singleton.StartPlayerAnimation (
				"LeftDodge");
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			FightManager.singleton.playerDodge = true;
			Invoke ("SetDodgeFalse", 0.5f);
			FightManager.singleton.StartPlayerAnimation (
				"RightDodge");
		}

	
	}


	void SetDodgeFalse()
	{
		FightManager.singleton.playerDodge = false;
	}
}
