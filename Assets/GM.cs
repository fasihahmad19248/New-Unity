using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public GameObject jumpButtonport;
    public GameObject flyButtonport;
    public GameObject jumpButtonland;
    public GameObject flyButtonland;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown)
        {   
            jumpButtonport.SetActive(true);
            flyButtonport.SetActive(true);
            jumpButtonland.SetActive(false);
            flyButtonland.SetActive(false);
        }
        else
        {
            jumpButtonport.SetActive(false);
            flyButtonport.SetActive(false);
            jumpButtonland.SetActive(true);
            flyButtonland.SetActive(true);   
        }
    }
}
