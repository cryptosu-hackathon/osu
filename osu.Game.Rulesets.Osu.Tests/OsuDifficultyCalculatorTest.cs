// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using NUnit.Framework;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Difficulty;
using osu.Game.Rulesets.Osu.Difficulty;
using osu.Game.Rulesets.Osu.Mods;
using osu.Game.Tests.Beatmaps;

namespace osu.Game.Rulesets.Osu.Tests
{
    [TestFixture]
    public class OsuDifficultyCalculatorTest : DifficultyCalculatorTest
    {
        protected override string ResourceAssembly => "osu.Game.Rulesets.Osu";

        [TestCase(6.6634445062299665d, "diffcalc-test")]
        [TestCase(1.0414203870195022d, "zero-length-sliders")]
        public void Test(double expected, string name)
            => base.Test(expected, name);

        [TestCase(8.3858089051603368d, "diffcalc-test")]
        [TestCase(1.2723279173428435d, "zero-length-sliders")]
        public void TestClockRateAdjusted(double expected, string name)
            => Test(expected, name, new OsuModDoubleTime());

        protected override DifficultyCalculator CreateDifficultyCalculator(WorkingBeatmap beatmap) => new OsuDifficultyCalculator(new OsuRuleset(), beatmap);

        protected override Ruleset CreateRuleset() => new OsuRuleset();
    }
}
