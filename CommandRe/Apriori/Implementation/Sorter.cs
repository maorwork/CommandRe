﻿using System;

namespace Apriori
{
    class Sorter : ISorter
    {
        string ISorter.Sort(string token)
        {
            char[] tokenArray = token.ToCharArray();
            Array.Sort(tokenArray);
            return new string(tokenArray);
        }
    }
}
