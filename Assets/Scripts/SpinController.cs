using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinController : MonoBehaviour {

    public GameObject row1;
    public GameObject row2;
    public GameObject row3;

    private Vector3 row1Position;
    private Vector3 row2Position;
    private Vector3 row3Position;

    private float stop1;
    private float stop2;
    private float stop3;

    //how long should we spin for.
    public float turnTime = 5f;
    private bool spinning = false;

    // Use this for initialization
    void Start () {

        // Store the row Transform component reference
        row1Position = row1.GetComponent<Transform>().position;
        row2Position = row2.GetComponent<Transform>().position;
        row3Position = row3.GetComponent<Transform>().position;

        // call the coroutines
        StartCoroutine(SpinFirstRow());
        StartCoroutine(SpinSecondRow());
        StartCoroutine(SpinThirdRow());
    }
    

    IEnumerator SpinFirstRow()
    {
        
        spinning = true;
        float time = 0;

        //Turn towards the side.
        while (time < turnTime)
        {
            time += Time.deltaTime;

            if (time > Random.Range(1f, 5f))
            {
                yield break;
            }

            row1.GetComponent<Transform>().position = new Vector3(row1Position.x, row1.GetComponent<Transform>().position.y - 0.5f, row1Position.z);
            
            yield return null;
        }
       
    }

    IEnumerator SpinSecondRow()
    {
        spinning = true;
        float time = 0;

        //Turn towards the side.
        while (time < turnTime)
        {
            time += Time.deltaTime;

            if (time > Random.Range(3f, 5f))
            {
                yield break;
            }

            row2.GetComponent<Transform>().position = new Vector3(row2Position.x, row2.GetComponent<Transform>().position.y - 0.5f, row2Position.z);

            yield return null;
        }

        yield break;
        
    }

    IEnumerator SpinThirdRow()
    {
        spinning = true;
        float time = 0;

        //Turn towards the side.
        while (time < turnTime)
        {
            time += Time.deltaTime;
            if (time > Random.Range(4f, 5f))
            {
                yield break;
            }
            row3.GetComponent<Transform>().position = new Vector3(row3Position.x, row3.GetComponent<Transform>().position.y - 0.5f, row3Position.z);

            yield return null;
        }

        yield break;
    }
}
