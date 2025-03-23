namespace CodeAlchemy.Core.Services
{
    public interface ICodeExecutionService
    {
        Task<string> ExecuteCodeAsync(string code);
    }
}
