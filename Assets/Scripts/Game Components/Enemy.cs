﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnBecameInvisible()
    {
    Destroy(this.gameObject);
    }


}
