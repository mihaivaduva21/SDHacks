using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveSelf : MonoBehaviour {

    public AudioClip impact;
    AudioSource audioSource;
    private Renderer render;


    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        render = this.GetComponent<MeshRenderer>();
        once = false;
    }

    public GameObject arrow;
    private bool once;
	// Update is called once per frame
	void Update () {
        
        if (Vector3.Distance(arrow.transform.position, this.transform.position) < 2)
        {
            if (once == false && this.gameObject.activeSelf == true)
            { 
                audioSource.PlayOneShot(impact, 1);
                once = true;
            }
           
        }
        if (!audioSource.isPlaying && once == true) this.gameObject.SetActive(false);
    }
}
