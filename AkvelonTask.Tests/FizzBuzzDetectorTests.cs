using System;
using Xunit;
using AkvelonTask;

namespace AkvelonTask.Tests
{
    public class FizzBuzzDetectorTests
    {
        private readonly FizzBuzzDetector _detector = new FizzBuzzDetector();

        [Fact]
        public void ShouldReplaceThirdAndFifthWords()
        {
            string input = "Mary had a little lamb";

            FizzBuzzResult result = _detector.GetOverlappings(input);

            Assert.Equal("Mary had Fizz little Buzz", result.OutputString);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void ShouldReplaceFizzBuzzOnFifteenthWord()
        {
            string input = "a a a a a a a a a a a a a a a";

            FizzBuzzResult result = _detector.GetOverlappings(input);

            Assert.Equal(
                "a a Fizz a Buzz Fizz a a Fizz Buzz a Fizz a a FizzBuzz",
                result.OutputString);
            
            Assert.Equal(7, result.Count);
        }

        [Fact]
        public void ShouldThrowExceptionWhenInputIsNull()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => _detector.GetOverlappings(null!));

            Assert.StartsWith("Input cannot be null.", exception.Message);
        }

        [Fact]
        public void ShouldThrowExceptionWhenInputIsSixCharacters()
        {
            var exception = Assert.Throws<ArgumentException>(() => _detector.GetOverlappings("abcdef"));

            Assert.StartsWith("Input length must be between 7 and 100.", exception.Message);
        }

        [Fact]
        public void ShouldThrowExceptionWhenInputIsHundredAndOneCharacters()
        {
            string input = new string('a', 101); 

            var exception = Assert.Throws<ArgumentException>(() => _detector.GetOverlappings(input));

            Assert.StartsWith("Input length must be between 7 and 100.", exception.Message);
        }

        [Fact]
        public void ShouldPreservePunctuation()
        {
            string input = "One, two! three?";

            FizzBuzzResult result = _detector.GetOverlappings(input);

            Assert.Equal("One, two! Fizz?", result.OutputString);
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public void ShouldTreatApostropheAsPartOfWord()
        {
            string input = "It's a nice day today";

            FizzBuzzResult result = _detector.GetOverlappings(input);

            Assert.Equal("It's a Fizz day Buzz", result.OutputString);
            Assert.Equal(2, result.Count);
        }
    }
}
