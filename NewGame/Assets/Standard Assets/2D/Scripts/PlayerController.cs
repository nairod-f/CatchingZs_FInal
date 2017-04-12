using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //how fast will the player move?
    public float speed = 40f;

    //we need the phyiscs object for the player to move
    private Rigidbody2D playerRB;

    //what are the screen limits? (horizontal)
    private float maximumX = 1f;

    //when the script wakes up, w eneed the components
    private void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        GameManager.GetCoords();
        maximumX = GameManager.MaximumX - 0.5f;
    }

    //move the player using physics
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");

        //the ammount /distance by which the player will move
        Vector2 pos = transform.position;
        Vector2 d = Vector2.right * h * speed * Time.deltaTime;

        //conoslidate th distance value
        d += pos;
        if (Mathf.Abs(d.x) > maximumX)
        {
            d.x = maximumX * Mathf.Sign(d.x);
        }

        playerRB.MovePosition(d);

    }

}
