using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{

    #region variables
    // this is a reference for the pipes
    public GameObject[] Sounds;

    // the area where a pipe will be generated
    protected float _leftLimit = -7.5f;
    protected float _rightLimit = 7.5f;

    // the distance between pipes
    protected float _distance = 1.5f;

    // the timing in which a pipe will be generated
    public float _pipeTimer = 1f;
    #endregion


    #region methods
    // the game manager will use this to start the game
    public void Start()
    {

        StartCoroutine("GenerateSound");

    }

    // this is a method that allows threaded time control
    IEnumerator GenerateSound()
    {

        // in an IEnumerator, we need an infinite loop
        while (true)
        {

            // create a random position for the pipes
            Vector2 pos = transform.position;
            pos = pos + (Vector2.down * _distance);
            pos.x = Random.Range(_leftLimit, _rightLimit);

            // create a new pipe at this position
            Instantiate(Sounds[Random.Range(0, Sounds.Length)], pos, Quaternion.identity);

            // do not occupy the program's activity
            // and wait for a number of seconds
            yield return new WaitForSeconds(_pipeTimer);

        }

    }
    #endregion

}
