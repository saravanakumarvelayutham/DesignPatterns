using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Builder
    {
        
    }

    public class Class
    {
        internal string Name;
        internal List<Field> Fields;
    }

    public class Field
    {
        internal string Name;
        internal string Type;
        public Field(string fieldName, string dataType)
        {
            Name = fieldName;
            Type = dataType;
        }
    }
    public class CodeBuilder
    {
        public Class ClObj = new Class();
        private const int IndentSize = 2;
        private const string OpeningBrace = "{";

        private const string ClosingBrace = "}";

        // TODO
        public CodeBuilder(string className)
        {
            ClObj.Name = className;
        }

        public CodeBuilder AddField(string fieldName, string dataType)
        {
            if (ClObj.Fields == null)
            {
                ClObj.Fields = new List<Field>();
            }
            ClObj.Fields.Add(new Field(fieldName, dataType));
            return this;
        }

        public override string ToString()
        {
            return ToStringImpl(ClObj);
        }

        public string EncloseFieldsInBraces(List<Field> fields)
        {
            var fieldsString = new StringBuilder();
            fieldsString.AppendLine(OpeningBrace);
            if (fields != null)
            {
                foreach (var field in fields)
                {
                    var fieldString = new string(' ', IndentSize) + "public " + field.Type + ' ' + field.Name + ';';
                    fieldsString.AppendLine(fieldString);
                }
            }
            fieldsString.AppendLine(ClosingBrace);
            return fieldsString.ToString();
        }

        private string ToStringImpl(Class clObj)
        {
            var output = new StringBuilder();
            var classStructure = string.Format("public class {0}", clObj.Name);
            output.AppendLine(classStructure);
            output.AppendLine(EncloseFieldsInBraces(clObj.Fields));
            return output.ToString();
        }
    }
}