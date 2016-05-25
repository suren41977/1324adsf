using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class skirtTypeabc : MonoBehaviour {
    public Dropdown skTypeABC;
    public Slider skirtBtmLvl;

    public GameObject visibleLAvatar;
    public GameObject[] visibleListA;
    public GameObject[] visibleListB;
    public GameObject[] visibleListC;
    public GameObject pLane;
    int sktbvl = -1;

    int frame_count = 0;

    // Use this for initialization
    void Start()
    {
        pLane.GetComponent<MeshRenderer>().enabled = true;
        visibleLAvatar.GetComponent<MeshRenderer>().enabled = false;
        visibleListA = GameObject.FindGameObjectsWithTag("SkirtA123");
        visibleListB = GameObject.FindGameObjectsWithTag("SkirtB124");
        visibleListC = GameObject.FindGameObjectsWithTag("SkirtC125");
        skTypeABC.value = 0;
    }
	
	// Update is called once per frame
	void Update () {
        frame_count++;
        if (skTypeABC.value == 0)
        {
            if (sktbvl==-1 ||sktbvl==1 ||sktbvl ==2)
            {
                sktbvl = 0;
                skirtBtmLvl.value = 0;
            }
            foreach (GameObject visibleA in visibleListA)
            {
                visibleA.GetComponent<MeshRenderer>().enabled = true;
            }
            foreach (GameObject visibleB in visibleListB)
            {
                visibleB.GetComponent<MeshRenderer>().enabled = false;
            }
            foreach (GameObject visibleC in visibleListC)
            {
                visibleC.GetComponent<MeshRenderer>().enabled = false;
            }
            GameObject.Find("SkirtA1 (Mask)").transform.localPosition = new Vector3(
                     GameObject.Find("SkirtA1 (Mask)").transform.localPosition.x,
                     skirtBtmLvl.value / 1000f,
                      GameObject.Find("SkirtA1 (Mask)").transform.localPosition.z
                    );
            GameObject.Find("SkirtA1 (Mask)").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("SkirtB1 (Mask)").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("SkirtC1 (Mask)").GetComponent<MeshRenderer>().enabled = false;
        }
        if (skTypeABC.value == 1)
        {
            if (sktbvl == -1 || sktbvl == 0 || sktbvl == 2)
            {
                sktbvl = 1;
                skirtBtmLvl.value = 0;
            }
            foreach (GameObject visibleA in visibleListA)
            {
                visibleA.GetComponent<MeshRenderer>().enabled = false;
            }
            foreach (GameObject visibleB in visibleListB)
            {
                visibleB.GetComponent<MeshRenderer>().enabled = true;
            }
            foreach (GameObject visibleC in visibleListC)
            {
                visibleC.GetComponent<MeshRenderer>().enabled = false;
            }
            GameObject.Find("SkirtB1 (Mask)").transform.localPosition = new Vector3(
                     GameObject.Find("SkirtB1 (Mask)").transform.localPosition.x,
                     skirtBtmLvl.value / 1000f,
                      GameObject.Find("SkirtB1 (Mask)").transform.localPosition.z
                    );
            GameObject.Find("SkirtA1 (Mask)").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("SkirtB1 (Mask)").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("SkirtC1 (Mask)").GetComponent<MeshRenderer>().enabled = false;
        }
        if (skTypeABC.value == 2)
        {
            if (sktbvl == -1 || sktbvl == 0 || sktbvl == 1)
            {
                sktbvl = 2;
                skirtBtmLvl.value = 0;
            }
            foreach (GameObject visibleA in visibleListA)
            {
                visibleA.GetComponent<MeshRenderer>().enabled = false;
            }
            foreach (GameObject visibleB in visibleListB)
            {
                visibleB.GetComponent<MeshRenderer>().enabled = false;
            }
            foreach (GameObject visibleC in visibleListC)
            {
                visibleC.GetComponent<MeshRenderer>().enabled = true;
            }
            GameObject.Find("SkirtC1 (Mask)").transform.localPosition = new Vector3(
                     GameObject.Find("SkirtC1 (Mask)").transform.localPosition.x,
                     skirtBtmLvl.value / 1000f,
                      GameObject.Find("SkirtC1 (Mask)").transform.localPosition.z
                    );
            GameObject.Find("SkirtA1 (Mask)").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("SkirtB1 (Mask)").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("SkirtC1 (Mask)").GetComponent<MeshRenderer>().enabled = true;
        }
        if (frame_count>=5)
        {
            visibleLAvatar.GetComponent<MeshRenderer>().enabled = true;
            pLane.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
