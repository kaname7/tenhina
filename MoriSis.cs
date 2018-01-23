using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoriSis : MonoBehaviour 
{
    public GameObject player;
    public GameObject poppoint;
    public Vector2 poppointpos;
    public float randomX;
    public Vector2 playerposX;
    public Vector2 playerposY;
    public GameObject Mori;
    public GameObject prefab;
	public float Loop_itme = 1.0f;

    void Start () 
	{
        poppointpos = new Vector2(poppoint.transform.position.x, poppoint.transform.position.y);
        StartCoroutine(loop());
    }

    private IEnumerator loop()
    {
        while (true)
        {
			yield return new WaitForSeconds(Loop_itme);
            //関数
            mori();
        }
    }

    //プレイヤーの座標
    void Playerpos()
    {
        playerposX.x = player.transform.localPosition.x;
        playerposY.y = player.transform.localPosition.y;
    }

    void mori()
    {
        randomX = UnityEngine.Random.Range(-2f, 2f);
        float popY = playerposY.y - 10.0f;
        prefab = Instantiate(Mori, new Vector3(playerposX.x, popY, 1.0f), Quaternion.identity) as GameObject;
    }

    void Update () 
	{
        Playerpos();
    }

   
}
