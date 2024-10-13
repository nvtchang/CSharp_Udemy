using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookbook.DataAccess
{
    class StringTextualRepository
    {
        private static readonly string Seperator = Environment.NewLine;
        public List<string> Read(string filePath)
        {
            var fileContents = File.ReadAllText(filePath);
            return fileContents.Split(Seperator).ToList();
        }

        public void Write(string filePath, List<string> strings) =>
            File.WriteAllText(filePath, string.Join(Seperator, strings));
    }
}
