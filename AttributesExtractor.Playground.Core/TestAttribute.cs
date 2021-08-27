﻿using System;

namespace AttributesExtractor.Playground
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class TestAttribute : Attribute
    {
        public TestAttribute(
            int @int = default,
            float @float = default,
            string text = default,
            string[] textArray = default,
            Type type = default)
        {
        }
    }
}