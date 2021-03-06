﻿using System;
using System.Collections.Generic;
using System.Text;
using Tensorflow.Keras.ArgsDefinition;

namespace Tensorflow.Keras.Optimizers
{
    /// <summary>
    /// Optimizer that implements the RMSprop algorithm.
    /// </summary>
    public class RMSprop : OptimizerV2
    {
        RMSpropArgs args;

        public RMSprop(RMSpropArgs args) : base(args)
        {
            this.args = args;
            _set_hyper("rho", args.RHO);
            _set_hyper("momentum", args.Momentum);
        }
    }
}
