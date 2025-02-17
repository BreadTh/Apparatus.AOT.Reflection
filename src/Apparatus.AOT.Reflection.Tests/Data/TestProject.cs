﻿using System.Linq;
using Buildalyzer;
using Buildalyzer.Workspaces;
using Microsoft.CodeAnalysis;

namespace Apparatus.AOT.Reflection.Tests.Data
{
    public static class TestProject
    {
        static TestProject()
        {
            var manager = new AnalyzerManager();
            manager.GetProject(@"../../../../Apparatus.AOT.Reflection.Playground/Apparatus.AOT.Reflection.Playground.csproj");
            manager.GetProject(
                @"../../../../Apparatus.AOT.Reflection.Playground.Core/Apparatus.AOT.Reflection.Playground.Core.csproj");
            Workspace = manager.GetWorkspace();

            Project = Workspace.CurrentSolution.Projects.First(o => o.Name == "Apparatus.AOT.Reflection.Playground");
            Core = Workspace.CurrentSolution.Projects.First(o => o.Name == "Apparatus.AOT.Reflection.Playground.Core");
        }

        public static Project Project { get; }
        public static Project Core { get; }

        public static AdhocWorkspace Workspace { get; }
    }
}