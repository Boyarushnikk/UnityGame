﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PepesGame
{
    public class EnemyMove : MonoBehaviour
    {

        public int Speed;

        private void FixedUpdate()
        {
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
        }

    }
}