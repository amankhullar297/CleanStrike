using System.Collections.Generic;

namespace CleanStrikeImpl
{
    internal static class StrikeFactory
    {
        private static Dictionary<StrikeType, IStrike> StrikeTypes = new Dictionary<StrikeType, IStrike>();

        internal static IStrike GetStrikeType(StrikeType strikeType)
        {
            switch (strikeType)
            {
                case StrikeType.Strike:
                    {
                        if (StrikeTypes.ContainsKey(strikeType))
                            return StrikeTypes.GetValueOrDefault(strikeType);
                        else
                        {
                            var strike = new SingleStrike();
                            StrikeTypes.Add(strikeType, strike);
                            return strike;
                        }
                    }

                case StrikeType.MultiStrike:
                    {
                        if (StrikeTypes.ContainsKey(strikeType))
                            return StrikeTypes.GetValueOrDefault(strikeType);
                        else
                        {
                            var strike = new MultiStrike();
                            StrikeTypes.Add(strikeType, strike);
                            return strike;
                        }
                    }

                case StrikeType.RedStrike:
                    {
                        if (StrikeTypes.ContainsKey(strikeType))
                            return StrikeTypes.GetValueOrDefault(strikeType);
                        else
                        {
                            var strike = new RedStrike();
                            StrikeTypes.Add(strikeType, strike);
                            return strike;
                        }
                    }

                case StrikeType.StrikerStrike:
                    {
                        if (StrikeTypes.ContainsKey(strikeType))
                            return StrikeTypes.GetValueOrDefault(strikeType);
                        else
                        {
                            var strike = new StrikerStrike();
                            StrikeTypes.Add(strikeType, strike);
                            return strike;
                        }
                    }

                case StrikeType.DefunctStrike:
                    {
                        if (StrikeTypes.ContainsKey(strikeType))
                            return StrikeTypes.GetValueOrDefault(strikeType);
                        else
                        {
                            var strike = new DefunctStrike();
                            StrikeTypes.Add(strikeType, strike);
                            return strike;
                        }
                    }

                case StrikeType.None:
                    {
                        if (StrikeTypes.ContainsKey(strikeType))
                            return StrikeTypes.GetValueOrDefault(strikeType);
                        else
                        {
                            var strike = new NoneStrike();
                            StrikeTypes.Add(strikeType, strike);
                            return strike;
                        }
                    }
            }

            return null;
        }
    }
}
