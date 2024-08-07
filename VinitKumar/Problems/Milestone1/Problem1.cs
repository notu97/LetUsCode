﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinitKumar.Utilities;

namespace VinitKumar.Problems.Milestone1
{
    public class Problem1
    {

        public void InOrderTraversalRecursive(TreeNode? Root)
        {
            if (Root == null) return;

            InOrderTraversalRecursive(Root.left);
            Console.WriteLine(Root.val);
            InOrderTraversalRecursive(Root.right);
        }
    }
}
