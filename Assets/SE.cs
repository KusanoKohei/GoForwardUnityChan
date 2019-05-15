using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour {


    //ブロックが地面等に接触した時の効果音
    private AudioSource mAudio;
    private Collider2D mCollider2D;

    // Use this for initialization
    void Start () {
        //必要なコンポーネントを取得する
        mAudio = GetComponent<AudioSource>();
        mCollider2D = GetComponent<Collider2D>();
    }
	
    
	// Update is called once per frame
	void Update () {

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground"|| collision.gameObject.tag == "Block")
        {
            //Debug.Log("地面にもブロックにも衝突");
            mAudio.Play();
        }

    }
}
