using System;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace HTMLRenderer
{
    public interface IElement
    {
        string Name { get; }
        string TextContent { get; set; }
        IEnumerable<IElement> ChildElements { get; }
        void AddElement(IElement element);
        void Render(StringBuilder output);
        string ToString();
    }

    public class HTMLElement : IElement
    {
        private ICollection<IElement> childElements;

        public HTMLElement(string name)
        {
            this.Name = name;
            this.childElements = new List<IElement>();
        }

        public HTMLElement(string name, string content)
            : this(name)
        {
            this.TextContent = content;
        }

        public virtual string Name { get; private set; }

        public virtual string TextContent { get; set; }

        public virtual IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        public virtual void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("<{0}>", this.Name);
            }

            if (!string.IsNullOrWhiteSpace(this.TextContent))
            {
                output.Append(this.CheckForSpecialChars(this.TextContent));
            }

            foreach (var childElement in this.ChildElements)
            {
                output.Append(childElement.ToString());
            }

            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("</{0}>", this.Name);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            this.Render(output);

            return output.ToString();
        }

        private string CheckForSpecialChars(string input)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<')
                {
                    output.Append("&lt;");
                }
                else if (input[i] == '>')
                {
                    output.Append("&gt;");
                }
                else if (input[i] == '&')
                {
                    output.Append("&amp;");
                }
                else
                {
                    output.Append(input[i]);
                }
            }

            return output.ToString();
        }
    }

    public interface ITable : IElement
    {
        int Rows { get; }
        int Cols { get; }
        IElement this[int row, int col] { get; set; }
    }

    public class HTMLTable : HTMLElement, ITable
    {
        private int rows;
        private int cols;
        private IElement[,] cells;

        public HTMLTable(int rows, int cols)
            : base("table")
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cells = new IElement[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The value of the rows have to be positive.");
                }

                this.rows = value;
            }
        }

        public int Cols 
        {
            get
            {
                return this.cols;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The value of the columns have to be positive.");
                }

                this.cols = value;
            }
        }

        public virtual IElement this[int row, int col]
        {
            get
            {
                return this.cells[row, col];
            }

            set
            {
                this.cells[row, col] = value;
            }
        }

        public override string TextContent
        {
            get
            {
                return null; // Tables have no text content
            }
            set
            {
                throw new InvalidOperationException("Tables have no text contents!");
            }
        }

        public override void Render(StringBuilder output)
        {
            output.Append("<table>");

            for (int row = 0; row < this.Rows; row++)
            {
                output.Append("<tr>");
                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append("<td>");
                    this.cells[row, col].Render(output);
                    output.Append("</td>");
                }

                output.Append("</tr>");
            }

            output.Append("</table>");
        }
    }

    public interface IElementFactory
    {
        IElement CreateElement(string name);
        IElement CreateElement(string name, string content);
        ITable CreateTable(int rows, int cols);
    }

    public class HTMLElementFactory : IElementFactory
    {
        public IElement CreateElement(string name)
        {
            return new HTMLElement(name);
        }

        public IElement CreateElement(string name, string content)
        {
            return new HTMLElement(name, content);
        }

        public ITable CreateTable(int rows, int cols)
        {
            return new HTMLTable(rows, cols);
        }
    }

    public class HTMLRendererCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using HTMLRenderer;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}
