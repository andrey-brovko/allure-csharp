﻿using System;
using AspectInjector.Broker;
using NUnit.Allure.Core.Steps;

namespace NUnit.Allure.Attributes
{
    [Injection(typeof(AllureStepAspect))]
    public class AllureStepAttribute : AllureStepBaseAttribute
    {
        public AllureStepAttribute(string name = null) : base(name)
        {
        }
    }
}