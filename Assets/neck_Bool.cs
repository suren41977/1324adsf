using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class neck_Bool : MonoBehaviour
{
    //public Slider topsUpperLevel;
    public Dropdown Nck_Bool;
    public Slider neckWdth;
    public Slider neckType;
    public Slider neckHtdSliderF;
    public Slider neckHtdSliderB;
    public Slider Sld_sleeve;

    int nck_bool = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //sleeve level: 0.243f to 0.063f
        nck_bool = Nck_Bool.value;
        if (Sld_sleeve.value < 0.063f)
        {
            //topsUpperLevel.gameObject.SetActive(true);
            neckType.gameObject.SetActive(false);
            neckWdth.gameObject.SetActive(false);
            neckHtdSliderB.gameObject.SetActive(false);
            neckHtdSliderF.gameObject.SetActive(false);

            //topsUpperLevel.GetComponentInChildren<CanvasRenderer>().SetAlpha(1);
            //Nck_Bool.Hide();
            Nck_Bool.transform.localScale = new Vector3(0f, 0f, 0f);
            Nck_Bool.value = 0;
            //Nck_Bool.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
            neckType.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
            neckWdth.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
            neckHtdSliderB.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
            neckHtdSliderF.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
        }
        else {
            if (nck_bool == 0)
            {
                neckType.gameObject.SetActive(false);
                neckWdth.gameObject.SetActive(false);
                neckHtdSliderB.gameObject.SetActive(false);
                neckHtdSliderF.gameObject.SetActive(false);

                neckType.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
                neckWdth.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
                neckHtdSliderB.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
                neckHtdSliderF.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
            }
            else if (nck_bool == 1)
            {
                neckType.gameObject.SetActive(true);
                neckWdth.gameObject.SetActive(true);
                neckHtdSliderB.gameObject.SetActive(false);
                neckHtdSliderF.gameObject.SetActive(true);

                neckType.GetComponentInChildren<CanvasRenderer>().SetAlpha(1);
                neckWdth.GetComponentInChildren<CanvasRenderer>().SetAlpha(1);
                neckHtdSliderB.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
                neckHtdSliderF.GetComponentInChildren<CanvasRenderer>().SetAlpha(1);
                GameObject.Find("model_J").transform.localScale =
                    new Vector3(GameObject.Find("model_J").transform.localScale.x,
                    neckHtdSliderF.value, 
                    GameObject.Find("model_J").transform.localScale.y);
                GameObject.Find("model_J").transform.localPosition =
                    new Vector3(
                        GameObject.Find("model_J").transform.localPosition.x,
                        -neckHtdSliderF.value * 1.4f / 78.15487f + (neckHtdSliderF.value - 78.15487f) / (neckHtdSliderF.value * 2.6f),
                        GameObject.Find("model_J").transform.localPosition.y
                        );


                GameObject.Find("model_J_back").transform.localScale =
                    new Vector3(GameObject.Find("model_J_back").transform.localScale.x,
                    neckHtdSliderB.value,
                    GameObject.Find("model_J_back").transform.localScale.y);
                GameObject.Find("model_J_back").transform.localPosition =
                    new Vector3(
                        GameObject.Find("model_J_back").transform.localPosition.x,
                        -neckHtdSliderB.value * 1.4f / 78.15487f + (neckHtdSliderB.value - 78.15487f) / (neckHtdSliderB.value * 2.6f),
                        GameObject.Find("model_J_back").transform.localPosition.y
                        );
            }
            else if (nck_bool == 2)
            {
                neckType.gameObject.SetActive(true);
                neckWdth.gameObject.SetActive(true);
                neckHtdSliderB.gameObject.SetActive(true);
                neckHtdSliderF.gameObject.SetActive(false);

                neckType.GetComponentInChildren<CanvasRenderer>().SetAlpha(1);
                neckWdth.GetComponentInChildren<CanvasRenderer>().SetAlpha(1);
                neckHtdSliderB.GetComponentInChildren<CanvasRenderer>().SetAlpha(1);
                neckHtdSliderF.GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
                GameObject.Find("model_J").transform.localScale =
                    new Vector3(GameObject.Find("model_J").transform.localScale.x,
                    neckHtdSliderF.value,
                    GameObject.Find("model_J").transform.localScale.y);
                GameObject.Find("model_J").transform.localPosition =
                    new Vector3(
                        GameObject.Find("model_J").transform.localPosition.x,
                        -neckHtdSliderF.value * 1.4f / 78.15487f + (neckHtdSliderF.value - 78.15487f) / (neckHtdSliderF.value * 2.6f),
                        GameObject.Find("model_J").transform.localPosition.y
                        );

                GameObject.Find("model_J_back").transform.localScale =
                    new Vector3(GameObject.Find("model_J_back").transform.localScale.x,
                    neckHtdSliderB.value, GameObject.Find("model_J_back").transform.localScale.y);
                GameObject.Find("model_J_back").transform.localPosition =
                    new Vector3(
                        GameObject.Find("model_J_back").transform.localPosition.x,
                        -neckHtdSliderB.value * 1.4f / 78.15487f + (neckHtdSliderB.value - 78.15487f) / (neckHtdSliderB.value * 2.45f),
                        GameObject.Find("model_J_back").transform.localPosition.y
                        );
            }
        }
    }
}