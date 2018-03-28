using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbEvent : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject btnObject;
	private GameObject zombie;

	public AudioClip audio;
	public AudioSource audioSource;

	void Start () {
		btnObject = GameObject.Find ("VirtualButton");
		btnObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

		zombie = GameObject.Find ("zombie");

		audioSource.clip = audio;

	}

	public void OnButtonPressed(VirtualButtonBehaviour vb){
		zombie.GetComponent<Animation> ().Play ();
		audioSource.Play ();
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){
		zombie.GetComponent<Animation> ().Stop ();
		audioSource.Stop ();
	}
}
	