﻿using System.Collections.Generic;
using NRUSharp.core.interfaces;

namespace NRUSharp.simulationFramework{
    public record ScenarioDescription(int Repetitions, int SimulationTime, List<List<INode>> ScenarioMatrix, string ResultsFileName);
}