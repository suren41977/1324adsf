using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class neckWidthScale : MonoBehaviour {
    public Slider neckWdSlider;

	// Use this for initialization
	void Start () { 
    }
	
	// Update is called once per frame
	void Update () {
        GameObject.Find("Sphere").transform.localScale =
            new Vector3(neckWdSlider.value, 1.375f, 1f);
        GameObject.Find("SphereB").transform.localScale =
            new Vector3(neckWdSlider.value, 1.375f, 1f);
    }
}
