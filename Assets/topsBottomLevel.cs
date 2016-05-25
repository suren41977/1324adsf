using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class topsBottomLevel : MonoBehaviour {

    public Slider topBottomLevel;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject.Find("Cube Mask FB").transform.localPosition = new Vector3(
             GameObject.Find("Cube Mask FB").transform.localPosition.x,
             topBottomLevel.value,
              GameObject.Find("Cube Mask FB").transform.localPosition.y
            );
	}
}
