﻿using Assets.Scripts.Data;
using Assets.Scripts.Shuffle;
using Assets.Scripts.Sort;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

namespace Assets.Scripts.Controllers
{
    class SortController : MonoBehaviour
    {
        private void Start()
        {
            this._selectionSort = this.gameObject.AddComponent<SelectionSort>();
            this._bubbleSort = this.gameObject.AddComponent<BubbleSort>();
            this._combSort = this.gameObject.AddComponent<CombSort>();
            this._mergeSort = this.gameObject.AddComponent<MergeSort>();
        }
        public IEnumerator Sort(CircleArray objects, Enums.Algorithm selectedSorting)
        {
            switch (selectedSorting)
            {
                case Enums.Algorithm.Selection:
                    return this._selectionSort.Sort(objects);
                case Enums.Algorithm.Bubble:
                    return this._bubbleSort.Sort(objects);
                case Enums.Algorithm.Comb:
                    return this._combSort.Sort(objects);
                case Enums.Algorithm.Merge:
                    return this._mergeSort.Sort(objects);
            }

            return null;
        }

        private SelectionSort _selectionSort;
        private BubbleSort _bubbleSort;
        private CombSort _combSort;
        private MergeSort _mergeSort;
    }
}
