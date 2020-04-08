using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    // 時間計測用の変数
    private float delta = 0;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine) {
            Destroy(gameObject);
        }
    }

    // 衝突時
    void OnCollisionEnter2D(Collision2D other) {
        // 他キューブに衝突した場合、音声を再生
        if (other.gameObject.tag == "CubeTag") {
            GetComponent<AudioSource>().Play();
        }

        // 地面に衝突した場合、音声を再生
        if (other.gameObject.name == "ground") {
            GetComponent<AudioSource>().Play();

        }
    }

}
