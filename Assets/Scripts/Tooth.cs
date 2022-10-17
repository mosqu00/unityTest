using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooth : MonoBehaviour
{
    private bool isGettingCavity_ = false;
    private bool hasBeenBlack_ = false;
    private float color_ = 255.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGettingCavity_ && color_ >= 0.01f)
        {
            color_ -= 1.0f;
        }
        if(color_ == 0.0f)
        {
            hasBeenBlack_ = true;
        }

        GetComponent<Renderer>().material.color = new Color32((byte)color_, (byte)color_, (byte)color_, 1);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Spear")
        {
            isGettingCavity_ = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isGettingCavity_ = false;
    }

    public bool GetState()
    {
        return hasBeenBlack_;
    }
}
