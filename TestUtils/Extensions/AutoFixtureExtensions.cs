using System;
using AutoFixture;

namespace TestUtils.Extensions
{
    public static class AutoFixtureExtensions
    {
        public static int CreateInt(this IFixture fixture, int min, int max)
        {
            return fixture.Create<int>() % (max - min + 1) + min;
        }

        public static string CreateRandomString(this IFixture fixture, int length)
        {
            var rnd = new Random();
            var randomChars = new char[length];

            for (var i = 0; i < length; i++)
            {
                randomChars[i] = (char)rnd.Next('a', 'z');
            }

            return new string(randomChars);
        }

    }
}