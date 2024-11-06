using System.Numerics;
using BudgetApp.Contracts;
using BudgetApp.Entities;
using Dapper;

namespace BudgetApp.Repository;

public class BudgetRepository:IBudgetRepository<BudGetEntity, Category, BudGetEntityDto>
{
   private readonly DataContext _context;
   public BudgetRepository()
   {
       _context = new DataContext();
   }
    public void Create(BudGetEntity model)
    {
       var query = @"INSERT INTO spendings VALUES (@Id, @SpendingDate, @Description, @Amount, @IdCategory)";
       model.Id = Guid.NewGuid().ToString();

       using var connection = _context.CreateConnection();
       connection.Execute(query, new { model.Id, model.SpendingDate, model.Description, model.Amount, model.IdCategory });
    }

    public IEnumerable<BudGetEntityDto> GetAll(int month)
    {
        var query = "";
        if (month > 0)
        {
             query = @"SELECT A.Id, A.SpendingDate, A.Description, A.Amount, B.CategoryName FROM spendings A
                      INNER JOIN Categories B on B.Id = A.IdCategory
                      WHERE (MONTH(SpendingDate) = @month)";
        }
        else
          query = @"SELECT A.Id, A.SpendingDate, A.Description, A.Amount, B.CategoryName FROM spendings A
                      INNER JOIN Categories B on B.Id = A.IdCategory";
    

        using var connection = _context.CreateConnection();
        var spendings = connection.Query<BudGetEntityDto>(query, new { month });
        return spendings;
    }

    public IEnumerable<Category> GetCategories()
    {
        var query = @"SELECT * FROM Categories";
        using var connection = _context.CreateConnection();
        
        return connection.Query<Category>(query);
    }

    public void Update(BudGetEntity model)
    {
        var query = @"UPDATE spendings SET Description = @Description, Amount = @Amount, Date = @Date WHERE Id = @Id";
        using var connection = _context.CreateConnection();
        connection.Execute(query, new { model });
    }
}
