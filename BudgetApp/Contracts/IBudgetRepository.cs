namespace BudgetApp.Contracts;

public interface IBudgetRepository<T, U, X> where T : class where U : class where X : class
{
    IEnumerable<X> GetAll(int value);
    void Create(T model);
    void Update(T model);

    IEnumerable<U> GetCategories();
}
