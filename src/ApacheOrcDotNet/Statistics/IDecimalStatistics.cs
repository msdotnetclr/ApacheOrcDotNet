﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApacheOrcDotNet.Statistics
{
    public interface IDecimalStatistics
    {
		decimal Minimum { get; }
		decimal Maximum { get; }
		decimal Sum { get; }
    }
}
