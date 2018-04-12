using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FireBallHardCoded : MonoBehaviour
{

    public string tag;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void UpdateFire()
    {

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            RaycastHit hit = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                tag = gameObject.tag;
                if (gameObject.tag == "Player1" || gameObject.tag == "Player2")
                {
                    Debug.Log("tag " + tag);
                }
            }
        }
    }
}
