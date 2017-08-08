﻿using System.Collections.Generic;
using System;

namespace BashSoft.DataStructures
{
    public interface ISimpleOrderedBag<T> : IEnumerable<T> 
        where T : IComparable<T>
    {
        bool Remove(T element);

        int Capacity { get; }
        void Add(T element);

        void AddAll(ICollection<T> collection);

        int Size { get; }

        string JoinWith(string joiner);
    }
}