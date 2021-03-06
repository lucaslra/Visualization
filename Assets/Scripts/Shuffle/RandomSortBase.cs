﻿using UnityEngine;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Data;
using Assets.Scripts.Computing;

namespace Assets.Scripts.Shuffle
{
    public class RandomSortBase : IShuffle
    {
        public virtual void Shuffle(CircleArray circles)
        {
            int r0, r1;

            for (int i = 0; i < LoopCount; i++)
            {
                r0 = Random.Range(0, circles.Length);
                r1 = Random.Range(0, circles.Length);

                Extension.Swap(circles[r0], circles[r1]);
            }
        }

        protected int LoopCount { get; set; }
    }
}