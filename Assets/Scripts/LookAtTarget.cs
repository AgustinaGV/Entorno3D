using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform target;
    public float speed = 0.7f;
    private Vector3 targetPosition;
    Honguito honguito;

    void Start()
    {
        honguito = GetComponent<Honguito>();
        targetPosition = transform.position + (transform.forward * 10);
    }
    void Update()
    {
        if (target == null) return;

        Vector3 direction = target.position;
        direction.y = transform.position.y;
        targetPosition = Vector3.Lerp(targetPosition, direction, speed * Time.deltaTime);
        transform.LookAt(targetPosition);
    }
    public void OnTarget(Transform target) //a quien tiene que mirar;
    {
        this.target = target; //esta var "vive" solo dentro de la func, hace ref a la var declarada en principio pero el valor es el que entra como target;
        if (target == null)
            honguito.SetNewState(Honguito.states.IDLE);
        else
            honguito.SetNewState(Honguito.states.ALERT);
    }
}
