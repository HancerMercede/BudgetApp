﻿using System.Configuration;

namespace BudgetApp.Repository;

public static class ConnectionString
{
    public static readonly string? Connection = "Data Source=xxx; Initial Catalog=BudgetDatabase; Integrated Security = True; Encrypt=false";
}

