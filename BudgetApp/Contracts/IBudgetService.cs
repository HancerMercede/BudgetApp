namespace BudgetApp.Contracts;

public interface IBudgetService<T, U> where T : class where U : class
{
    IEnumerable<U> GetAll(int value);
    void Create(T model);
    void Update(T model);
}
