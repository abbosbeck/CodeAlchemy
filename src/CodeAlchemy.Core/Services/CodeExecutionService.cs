using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace CodeAlchemy.Core.Services
{
    public class CodeExecutionService
    {
        public async Task<string> ExecuteCodeAsync(string code)
        {
            try
            {
                var result = await CSharpScript.EvaluateAsync(code, ScriptOptions.Default);
                
                return result?.ToString() ?? "No Output";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
