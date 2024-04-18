using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMovement : MonoBehaviour
{
    [SerializeField] GameObject[] TitikTemu;
    int CurrentTitikTemu = 0;
    [SerializeField] float speed = 1;
    void Update()
    {
        if (Vector3.Distance(transform.position, TitikTemu[CurrentTitikTemu].transform.position) < .1f)
        {
            CurrentTitikTemu++;
            if (CurrentTitikTemu >= TitikTemu.Length)
            {
                CurrentTitikTemu = 0;

            }


        }

        transform.position = Vector3.MoveTowards(transform.position, TitikTemu[CurrentTitikTemu].transform.position, speed * Time.deltaTime);

    }
}
