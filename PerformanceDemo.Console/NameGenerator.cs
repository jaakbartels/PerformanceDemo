using System.Collections.Generic;

namespace PerformanceDemo
{
    public class NameGenerator
    {
        public NameGenerator(List<string> firstNames, List<string> lastNames)
        {
            _firstNames = firstNames;
            _lastNames = lastNames;
        }

        private readonly List<string> _firstNames;
        private readonly List<string> _lastNames;

        public IEnumerable<string> GetNames()
        {
            var lastNameIndex = 0;
            var firstNameIndex = 0;

            while (true)
            {
                var result = $"{_firstNames[firstNameIndex]} {_lastNames[lastNameIndex]}";
                yield return result;
                lastNameIndex++;
                if (lastNameIndex >= _lastNames.Count) lastNameIndex = 0;
                firstNameIndex++;
                if (firstNameIndex >= _firstNames.Count) firstNameIndex = 0;
            }

        }
    }
}