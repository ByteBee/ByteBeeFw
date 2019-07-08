using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ByteBee.Utilities
{
    public interface IInflector
    {
        string Camelize(string lowercaseAndUnderscoredWord);
        string Capitalize(string word);
        string Dasherize(string underscoredWord);
        string Humanize(string lowercaseAndUnderscoredWord);
        string Ordinalize(string number);
        string Pascalize(string lowercaseAndUnderscoredWord);
        string Pluralize(string word);
        string Singularize(string word);
        string Slugrize(string word);
        string Slugrize(string word, string separator);
        string Titleize(string word);
        string Uncapitalize(string word);
        string Underscore(string pascalCasedWord);
    }

    internal class InflectorImpl : IInflector
    {
        private readonly IList<Rule> _plurals = new List<Rule>();
        private readonly IList<Rule> _singulars = new List<Rule>();
        private readonly IList<string> _uncountables = new List<string>();

        public InflectorImpl()
        {
            AddPlural("$", "s");
            AddPlural("s$", "s");
            AddPlural("(ax|test)is$", "$1es");
            AddPlural("(octop|vir)us$", "$1i");
            AddPlural("(alias|status)$", "$1es");
            AddPlural("(bu)s$", "$1ses");
            AddPlural("(buffal|tomat)o$", "$1oes");
            AddPlural("([ti])um$", "$1a");
            AddPlural("sis$", "ses");
            AddPlural("(?:([^f])fe|([lr])f)$", "$1$2ves");
            AddPlural("(hive)$", "$1s");
            AddPlural("([^aeiouy]|qu)y$", "$1ies");
            AddPlural("(x|ch|ss|sh)$", "$1es");
            AddPlural("(matr|vert|ind)ix|ex$", "$1ices");
            AddPlural("([m|l])ouse$", "$1ice");
            AddPlural("^(ox)$", "$1en");
            AddPlural("(quiz)$", "$1zes");

            AddSingular("s$", "");
            AddSingular("(n)ews$", "$1ews");
            AddSingular("([ti])a$", "$1um");
            AddSingular("((a)naly|(b)a|(d)iagno|(p)arenthe|(p)rogno|(s)ynop|(t)he)ses$", "$1$2sis");
            AddSingular("(^analy)ses$", "$1sis");
            AddSingular("([^f])ves$", "$1fe");
            AddSingular("(hive)s$", "$1");
            AddSingular("(tive)s$", "$1");
            AddSingular("([lr])ves$", "$1f");
            AddSingular("([^aeiouy]|qu)ies$", "$1y");
            AddSingular("(s)eries$", "$1eries");
            AddSingular("(m)ovies$", "$1ovie");
            AddSingular("(x|ch|ss|sh)es$", "$1");
            AddSingular("([m|l])ice$", "$1ouse");
            AddSingular("(bus)es$", "$1");
            AddSingular("(o)es$", "$1");
            AddSingular("(shoe)s$", "$1");
            AddSingular("(cris|ax|test)es$", "$1is");
            AddSingular("(octop|vir)i$", "$1us");
            AddSingular("(alias|status)es$", "$1");
            AddSingular("^(ox)en", "$1");
            AddSingular("(vert|ind)ices$", "$1ex");
            AddSingular("(matr)ices$", "$1ix");
            AddSingular("(quiz)zes$", "$1");

            AddIrregular("person", "people");
            AddIrregular("man", "men");
            AddIrregular("child", "children");
            AddIrregular("sex", "sexes");
            AddIrregular("move", "moves");

            AddUncountable("equipment");
            AddUncountable("information");
            AddUncountable("rice");
            AddUncountable("money");
            AddUncountable("species");
            AddUncountable("series");
            AddUncountable("fish");
            AddUncountable("sheep");
        }

        private sealed class Rule
        {
            private readonly Regex _regex;
            private readonly string _replacement;

            public Rule(string pattern, string replacement)
            {
                _regex = new Regex(pattern, RegexOptions.IgnoreCase);
                _replacement = replacement;
            }

            public string Apply(string word)
            {
                if (!_regex.IsMatch(word))
                {
                    return null;
                }

                return _regex.Replace(word, _replacement);
            }
        }

        private void AddIrregular(string singular, string plural)
        {
            AddPlural("(" + singular[0] + ")" + singular.Substring(1) + "$", "$1" + plural.Substring(1));
            AddSingular("(" + plural[0] + ")" + plural.Substring(1) + "$", "$1" + singular.Substring(1));
        }

        private void AddUncountable(string word)
        {
            _uncountables.Add(word.ToLower());
        }

        private void AddPlural(string rule, string replacement)
        {
            _plurals.Add(new Rule(rule, replacement));
        }

        private void AddSingular(string rule, string replacement)
        {
            _singulars.Add(new Rule(rule, replacement));
        }

        private string ApplyRules(IList<Rule> rules, string word)
        {
            string result = word;

            if (!_uncountables.Contains(word.ToLower()))
            {
                for (int i = rules.Count - 1; i >= 0; i--)
                {
                    if ((result = rules[i].Apply(word)) != null)
                    {
                        break;
                    }
                }
            }

            return result;
        }

        public string Pluralize(string word)
        {
            return ApplyRules(_plurals, word);
        }

        public string Singularize(string word)
        {
            return ApplyRules(_singulars, word);
        }

        public string Titleize(string word)
        {
            return Regex.Replace(Humanize(Underscore(word)), @"\b([a-z])",
                match => match.Captures[0].Value.ToUpper());
        }

        public string Humanize(string lowercaseAndUnderscoredWord)
        {
            return Capitalize(Regex.Replace(lowercaseAndUnderscoredWord, @"_", " "));
        }

        public string Pascalize(string lowercaseAndUnderscoredWord)
        {
            return Regex.Replace(lowercaseAndUnderscoredWord, "(?:^|_)(.)",
                match => match.Groups[1].Value.ToUpper());
        }

        public string Camelize(string lowercaseAndUnderscoredWord)
        {
            return Uncapitalize(Pascalize(lowercaseAndUnderscoredWord));
        }

        public string Underscore(string pascalCasedWord)
        {
            string word = Regex.Replace(pascalCasedWord, @"([A-Z]+)([A-Z][a-z])", "$1_$2");
            word = Regex.Replace(word, @"([a-z\d])([A-Z])", "$1_$2");
            word = Regex.Replace(word, @"[-\s]", "_").ToLower();
            return word;
        }

        public string Capitalize(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }

        public string Uncapitalize(string word)
        {
            return word.Substring(0, 1).ToLower() + word.Substring(1);
        }

        public string Ordinalize(string number)
        {
            int.TryParse(number, out int n);

            new Switch<int>(n % 10)
                .When(i => i % 10 >= 11 && i % 10 <= 13, _ => number += "th")
                .When(1, _ => number += "st")
                .When(2, _ => number += "nd")
                .When(3, _ => number += "rd");

            return number;
        }

        public string Dasherize(string underscoredWord)
        {
            return underscoredWord.Replace('_', '-');
        }

        public string Slugrize(string word)
        {
            return Slugrize(word, "-");
        }

        public string Slugrize(string word, string separator)
        {
            string result = Titleize(word);
            result = result.Replace(" ", separator);
            return result.ToLowerInvariant();
        }
    }
}
