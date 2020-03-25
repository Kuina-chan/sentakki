﻿using NUnit.Framework;
using osu.Game.Rulesets.Maimai.UI.Components;
using osu.Game.Tests.Visual;
using System;
using System.Collections.Generic;

namespace osu.Game.Rulesets.Maimai.Tests.UI
{
    [TestFixture]
    public class TestSceneMaimaiRing : OsuTestScene
    {
        public override IReadOnlyList<Type> RequiredTypes => new[]
        {
            typeof(MaimaiRing)
        };

        public TestSceneMaimaiRing()
        {
            Add(new MaimaiRing());
        }
    }
}