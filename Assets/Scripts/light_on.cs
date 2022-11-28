using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_on : MonoBehaviour
{
    Light torch;
    // Start is called before the first frame update
    void Start()
    {
        torch = GetComponent<Light>();
        torch.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        change_power();
    }

    void change_power()
    {
        if(Input.GetKeyDown("f"))
        {
            if (torch.isActiveAndEnabled)
            {
                torch.enabled = false;
            }
            else
            {
                torch.enabled = true;
            }
        }
    }
}
