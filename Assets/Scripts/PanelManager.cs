using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] private GameObject panelClear;
    [SerializeField] private GameObject panelOver;
    [SerializeField] private GameObject player;
    [SerializeField] private Tooth[] teeth_;

    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(player.gameObject.transform.position.y <= -10)
        {
            panelOver.SetActive(true);
        }

        int num = 0;
        for (int i = 0; i < 12; i++)
        {
            if (teeth_[i].GetState())
            {
                num++;
            }
        }

        if(num >= 12)
        {
            panelClear.SetActive(true);
        }
    }
}
