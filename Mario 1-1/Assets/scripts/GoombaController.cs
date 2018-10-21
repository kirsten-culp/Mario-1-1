using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaController : MonoBehaviour {
    public float speed;
    public Transform wallHitBox;
    public float wallHitWidth;
    public float wallHitHeight;
    public LayerMask isGround;
    private bool wallHit;
    private bool isOnGround;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
        wallHit = Physics2D.OverlapBox(wallHitBox.position, new Vector2(wallHitWidth, wallHitHeight), 0, isGround);
        if (wallHit == true)
        {
            speed = speed * -1;
        }
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
