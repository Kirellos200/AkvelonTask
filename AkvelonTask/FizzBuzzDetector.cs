using System;
using System.Text;

namespace AkvelonTask
{
public class FizzBuzzDetector 
    {
        /// <summary>
        /// This method applies the FizzBuzz replacement rules to the given input.
        /// Its input is the text to process.
        /// It returns the processed output and replacement count.
        /// </summary>
        public FizzBuzzResult getOverlappings(string input)
        {
            ValidateInput(input);

            StringBuilder output = new StringBuilder();

            int wordNumber = 0;
            int count = 0;
            int index = 0;

            while (index < input.Length)
            {
                char current = input[index];

                if (IsWordCharacter(current))
                {
                    StringBuilder word = new StringBuilder();

                    // Read the entire word
                    while (index < input.Length && IsWordCharacter(input[index]))
                    {
                        word.Append(input[index]);
                        index++;
                    }

                    wordNumber++;

                    string replacement = GetReplacement(wordNumber);

                    // Append the word to the output
                    if (replacement == null)
                    {
                        output.Append(word);
                    }
                    else
                    {
                        output.Append(replacement);
                        count++;
                    }
                }
                else
                {
                    // Preserve punctuation and whitespace as they should appear in the output as well
                    output.Append(current);
                    index++;
                }
            }

            return new FizzBuzzResult 
            { 
                OutputString = output.ToString(), 
                Count = count 
            };
        }

        /// <summary>
        /// Helper method that replaces every third word with "Fizz",
        /// every fifth word with "Buzz",
        /// and every fifteenth word with "FizzBuzz".
        /// </summary>
        private string GetReplacement(int wordNumber)
        {
            if (wordNumber % 15 == 0)
            {
                return "FizzBuzz";
            }

            if (wordNumber % 3 == 0)
            {
                return "Fizz";
            }

            if (wordNumber % 5 == 0)
            {
                return "Buzz";
            }

            return null!;
        }

        /// <summary>
        /// Helper method that validates the input to not be null and its length to be between 7 and 100 inclusive.
        /// Otherwise, throw exception.
        /// </summary>
        private void ValidateInput(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Input cannot be null.");
            }

            if (input.Length < 7 || input.Length > 100)
            {
                throw new ArgumentException("Input length must be between 7 and 100.", nameof(input));
            }
        }

        /// <summary>
        /// Helper method that checks whether a character is considered part of a word.
        /// I included the " ' " as part of a word to satisfy the given example in the task
        /// </summary>
        private bool IsWordCharacter(char c)
        {
            return char.IsLetterOrDigit(c) || c == '\'';
        }
    }
}