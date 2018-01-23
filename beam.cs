using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beam : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		firing();
    }

    void firing ()
    {
        if (this.transform.localScale.x > 0)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x - 0.01f, this.transform.localScale.y, this.transform.localScale.z);
        }
    }

    void alarm()
    {

    }
}
