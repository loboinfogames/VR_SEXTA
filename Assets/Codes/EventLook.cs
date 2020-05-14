﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLook : MonoBehaviour
{
    public AudioSource sound;
    public GameObject toEnable;
    public GameObject toDisable;
    public GameObject toDisable2;
    public Rigidbody rdb;
    public Vector3 force;

    //funcao que é chamada depois de um tempo olhando
    public void ButtonAction()
    {
        //toca o som escolhido
        if (sound)
        {
            sound.Play();
        }
        //habilita gameobjec selecionado
        if (toEnable)
        {
            toEnable.SetActive(true);
        }
        //desabilita gameobjec selecionado
        if (toDisable)
        {
            toDisable.SetActive(false);
        }
        if (toDisable2)
        {
            toDisable2.SetActive(false);
        }
        //adiciona uma força no objeto selecionado
        if (rdb)
        {
            rdb.AddForce(force,ForceMode.Impulse);
        }
    }

    //se acontece uma colisao toca o som
    private void OnCollisionEnter(Collision collision)
    {
        if (sound)
        {
            sound.Play();
        }
    }

}
