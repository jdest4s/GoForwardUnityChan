using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
    //サウンド
    AudioSource audioSource;

    public AudioClip sound1;//キューブ同士で接触した場合の音
    public AudioClip sound2;//キューブと地面が接触した場合の音

    // Start is called before the first frame update
    void Start()
    {
        //コンポーネントを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter2D(Collision2D other)
    {
       //キューブに接触した場合
       if (other.gameObject.tag == "Cubetag")
       {
         //指定した音を1回鳴らす
         audioSource.PlayOneShot(this.sound1);
       }

       //地面に接触した場合
       if (other.gameObject.tag == "Groundtag")
       {
         //指定した音を1回鳴らす
         audioSource.PlayOneShot(this.sound2);
       }        
    }
}

