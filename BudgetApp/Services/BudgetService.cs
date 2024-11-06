

using Accessibility;
using BudgetApp.Contracts;
using BudgetApp.Entities;
using BudgetApp.Repository;

namespace BudgetApp.Services;

public class BudgetService : IBudgetService<BudGetEntity, BudGetEntityDto>
{
    private readonly BudgetRepository repository;

    public BudgetService()
    {
        repository = new BudgetRepository();
    }

    public void Create(BudGetEntity model)
    {
        repository.Create(model);
    }

    public IEnumerable<BudGetEntityDto> GetAll(int value)
    {
        return repository.GetAll(value);
    }

    public void Update(BudGetEntity model)
    {
        repository.Update(model);
    }

    public IEnumerable<Category> GetCategories()
    { 
      return repository.GetCategories();
    }
}
