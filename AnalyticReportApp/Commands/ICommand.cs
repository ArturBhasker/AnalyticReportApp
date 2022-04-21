namespace ArturBhasker.AnalitycReportBeeLine.Commands
{
    public interface ICommand<T>
    {
        Task<T> ExecuteAsync(CancellationToken cancellationToken);
    }
}
