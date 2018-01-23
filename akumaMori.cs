using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class akumaMori : MonoBehaviour {


    public Vector2 speed = new Vector3(0.05f, 0.05f);
    private Vector3 Position;
    private float rad;
    public GameObject targetObject;

    // Use this for initialization
    void Start () {
        targetObject = GameObject.FindWithTag("Player");
        Vector3 pos = transform.position;
        pos.z += 1;
        transform.position = pos;

        rad = Mathf.Atan2(
            targetObject.transform.position.y - transform.position.y,
            targetObject.transform.position.x - transform.position.x
            );
    }

    // Update is called once per frame
    void Update (){
        // 現在位置をPositionに代入
        Position = transform.position;
        // x += SPEED * cos(ラジアン)
        // y += SPEED * sin(ラジアン)
        // これで特定の方向へ向かって進んでいく。
        Position.x += speed.x * Mathf.Cos(rad);
        Position.y += speed.y * Mathf.Sin(rad);
        Position.z = 2;
        // 現在の位置に加算減算を行ったPositionを代入する
        transform.position = Position;
    }

}
