using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class akuma : MonoBehaviour {

    public Transform  player;
    //GameObject prefab;
    public GameObject Mori;
    public float time = 5;


    // Use this for initialization
    public void Start ()
    {

        Vector3 player = GameObject.Find("Player_Angel").transform.position;
        Vector3 a = GameObject.Find("akuma").transform.position;

        float X = player.x;
        // relativePos = p - a;

        StartCoroutine(shot());

        
    }

    // Update is called once per frame
    void Update ()
    {
        //向き
        var diff = (player.position - transform.position).normalized;
        transform.rotation = Quaternion.FromToRotation(Vector3.down, diff);

        // 自身の向きベクトル取得
        float angleDir = transform.eulerAngles.z * (Mathf.PI / 180.0f);
        Vector3 dir = new Vector3(Mathf.Cos(angleDir), Mathf.Sin(angleDir), 0.0f);
    }

    private IEnumerator shot()
    {
        while (true)
        {
            // time毎にループします
            yield return new WaitForSeconds(time);
            Vector3 a = GameObject.Find("akuma").transform.position;
            float X = a.x;
            float Y = a.y;
            float Z = a.z;
            Instantiate(Mori, new Vector3(X,Y,Z), Quaternion.identity);
        }
        
        
    }
}
