using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class VideoEntrada : MonoBehaviour {

	public VideoPlayer video;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Awake(){
		video = GetComponent<VideoPlayer> ();
		video.Play();
		video.loopPointReached += CheckOve;
	}
	void CheckOve(VideoPlayer vp){
		
		SceneManager.LoadScene (1);
	}
}
