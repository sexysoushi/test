using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSoundRandom : MonoBehaviour
{

	Animator anim;

	string[] animListLove = new string[] {
		"Pose09",
		"Pose08",
		"Pose04",
		"wave",
		"Wave"

	};

	string[] animListRandom = new string[] { 
		"dancing 2",
		"Unarmed-Idle", 
		"Unarmed-Fall"
	};

	string[] animListJoyeuxAnniversaire = new string[] { 
		"dancing rumba"
	};


	AudioSource audio;
	public List<AudioClip> audioList;
	private Vector3 initPos;

	// Use this for initialization
	void Start ()
	{
		initPos = this.transform.position;
		anim = GetComponent<Animator> ();
		audio = GetComponent<AudioSource> ();

	}

	public void JoyeuxAnniversaire()
	{
		this.transform.position = initPos;
		anim.Play (animListJoyeuxAnniversaire [0]);
		audio.clip = audioList [0];
		audio.Play ();
	}

	//bouton love
	public void Love ()
	{
		this.transform.position = initPos;
		anim.Play (animListLove [Random.Range (0, animListLove.Length)]);
		//audio.clip = audioList [Random.Range (8, 18)];
		//audio.Play ();
	}

	//bouton random
	public void ChangeAnim ()
	{
		this.transform.position = initPos;
		int nbInList = Random.Range (0, animListRandom.Length);
		if(nbInList == 0)
		{
			anim.Play (animListRandom [nbInList]);
			audio.clip = audioList [1];
			audio.Play ();
		}
		else{

			anim.Play (animListRandom [nbInList]);
		}
//		audio.clip = audioList [Random.Range (18, 20)];
//		audio.Play ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
