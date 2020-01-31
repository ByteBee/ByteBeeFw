using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using ByteBee.Configuration.Exceptions;

namespace ByteBee.Configuration.Impl
{
    public class StandardConfigurationStore : IConfigurationStore
    {
        private string _pathToConfigurationFile;

        public StandardConfigurationStore(string pathToConfigurationFile)
        {
            _pathToConfigurationFile = pathToConfigurationFile;
        }

        public ConfiguratorRepresentation Load()
        {
            var output = new ConfiguratorRepresentation();

            IEnumerable<string> fileContent = File.ReadLines(_pathToConfigurationFile)
                .Select(l => l.Trim());

            string category = "";
            
            foreach (string line in fileContent)
            {
                if (line.StartsWith("[", StringComparison.Ordinal))
                {
                    category = "";
                    for (int i = 1; i < line.Length; i++)
                    {
                        if (line[i] == ']') break;

                        category += line[i];
                    }
                }
                else if (string.IsNullOrWhiteSpace(line))
                {
                    // skip empty lines
                }
                else if (line.StartsWith(";", StringComparison.Ordinal))
                {
                    // this is a comment
                }
                else if (line.StartsWith("#", StringComparison.Ordinal))
                {
                    // this is a comment
                }
                else
                {
                    if (line[0] != '_' && !char.IsLetter(line[0]))
                    {
                        throw new UnexpectedConfigurationLineException(line);
                    }

                    string key = "";
                    string content = "";
                    bool equalSignReached = false;
                    bool isQuoteOpen = false;

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '=')
                        {
                            equalSignReached = true;
                            continue;
                        }

                        if (!equalSignReached)
                        {
                            key += line[i];
                        }
                        else
                        {
                            if (line[i] == '"' || line[i] == '\'')
                            {
                                isQuoteOpen = !isQuoteOpen;
                                continue;
                            }

                            if (!isQuoteOpen && line[i] == ';' || line[i] == '#')
                            {
                                break;
                            }

                            content += line[i];
                        }
                    }

                    output.Set(category, key.Trim(), content.Trim());
                }
            }

            return output;
        }

        public void Save(ConfiguratorRepresentation representation)
        {
            Dictionary<string, Dictionary<string, object>> items = StructurizeItems(representation);
            string fileContent = PrepareItemRepresentation(items);
            PersistData(fileContent);
        }

        private Dictionary<string, Dictionary<string, object>> StructurizeItems(ConfiguratorRepresentation representation)
        {
            var output = new Dictionary<string, Dictionary<string, object>>();
            Dictionary<string, object> items = representation.GetItems();

            foreach (KeyValuePair<string, object> current in items.OrderBy(i => i.Key))
            {
                string category = ConfiguratorRepresentation.GetCategory(current.Key);
                string key = ConfiguratorRepresentation.GetKey(current.Key);

                if (!output.ContainsKey(category))
                {
                    output.Add(category, new Dictionary<string, object>());
                }

                output[category][key] = current.Value;
            }

            return output;
        }

        private string PrepareItemRepresentation(Dictionary<string, Dictionary<string, object>> items)
        {
            string output = string.Empty;

            foreach (KeyValuePair<string, Dictionary<string, object>> category in items)
            {
                output += $"[{category.Key}]{Environment.NewLine}";
                
                foreach (KeyValuePair<string, object> current in category.Value)
                {
                    output += $"{current.Key} = {current.Value}{Environment.NewLine}";
                }

                output += Environment.NewLine;
            }

            return output;
        }

        private void PersistData(string fileContent)
        {
            File.WriteAllText(_pathToConfigurationFile, fileContent);
        }
    }
}