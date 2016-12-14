using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CubeBgmController : MonoBehaviour {

    public AudioClip blockSE;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
	
	}

    // 接触した時に実行する内容(2D版)
    private void OnCollisionEnter2D(Collision2D collision) {
        string yourTag = collision.gameObject.tag;

        // ブロックと衝突した際に音を鳴らす
        if (yourTag == "CubeTag") {
            GetComponent<AudioSource>().PlayOneShot(blockSE);
        }

        // 地面と衝突した際に音を鳴らす
        if (yourTag == "groundTag") {
            GetComponent<AudioSource>().PlayOneShot(blockSE);
        }
    }

    /*
    private void OnCollisionEnter(Collision collision) {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "CubeTag") {
            GetComponent<AudioSource>().PlayOneShot(blockSE);
         }
     }
     */
}
