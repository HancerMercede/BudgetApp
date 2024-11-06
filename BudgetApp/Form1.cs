using System.Globalization;
using Accessibility;

using BudgetApp.Entities;
using BudgetApp.Helpers;
using BudgetApp.Services;
using Mapster;

namespace BudgetApp;

public partial class BudgetApp : Form
{
    private readonly BudgetService _budgetService;
    public BudgetApp()
    {
        InitializeComponent();
        _budgetService = new BudgetService();
    }

    private void BudgetApp_Load(object sender, EventArgs e)
    {
        GetAll(0);
        DisableButtonWhenFieldsAreEmpty();
    }

    private void GetAll(int value)
    {
        var spendingns = _budgetService.GetAll(value);
        var spendingsDto = spendingns.Adapt<IEnumerable<DisplayBudgetToClient>>();
        dgvSpendings.DataSource = spendingsDto.ToList();
        dgvSpendings.Columns["CategoryName"].HeaderText = "Category";
        dgvSpendings.Columns["SpendingDate"].HeaderText = "Date";
        CalculateTotalAmount();
        GetCategories();
        GetMonths();
    }

    private void GetMonths()
    {
        var months = new Dictionary<string, int>();
        months.Add("Enero", 1);
        months.Add("Febrero", 2);
        months.Add("Marzo", 3);
        months.Add("Abril", 4);
        months.Add("Mayo", 5);
        months.Add("Junio", 6);
        months.Add("Julio", 7);
        months.Add("Agosto", 8);
        months.Add("Septiembre", 9);
        months.Add("Octubre", 10);
        months.Add("Noviembre", 11);
        months.Add("Diciembre", 12);

        cmbMonths.DataSource = months.ToList();
        cmbMonths.DisplayMember = "Key";
        cmbMonths.ValueMember = "Value";
    }

    private void GetCategories()
    {
        cmbCategories.DataSource = _budgetService.GetCategories();
        cmbCategories.ValueMember = "Id";
        cmbCategories.DisplayMember = "CategoryName";

    }
    private void CreateRecord()
    {
        var budget = new BudGetEntity()
        {
            Description = txtDescription.Text,
            Amount = Convert.ToDecimal(txtAmount.Text),
            SpendingDate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()),
            IdCategory = cmbCategories?.SelectedValue?.ToString()
        };

        _budgetService.Create(budget);
    }

    private void CalculateTotalAmount()
    {
        double sum = 0.0;
        for (var i = 0; i < dgvSpendings.Rows.Count; i++)
        {
            sum += Convert.ToDouble(dgvSpendings.Rows[i].Cells[2].Value);
        }
        lblTotalAmount.Text = sum.ToString(CultureInfo.InvariantCulture);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        CreateRecord();
        GetAll(0);
    }

    private void DisableButtonWhenFieldsAreEmpty()
    {
        if (string.IsNullOrWhiteSpace(txtDescription.Text) || string.IsNullOrWhiteSpace(txtAmount.Text))
        {
            btnSave.Enabled = false;
        }
        else
            btnSave.Enabled = true;
    }

    private void txtDescription_TextChanged(object sender, EventArgs e)
    {
        btnSave.Enabled = true;
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
        var value = Convert.ToInt32(cmbMonths.SelectedValue);
        GetAll(value);
    }
}