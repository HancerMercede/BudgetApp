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
    private readonly int _month;
    public BudgetApp()
    {
        InitializeComponent();
        _budgetService = new BudgetService();
         _month = DateTime.Now.Month;
    }

    private void BudgetApp_Load(object sender, EventArgs e)
    {
        lblDateComplete.Text = DateTime.Now.ToString("MMMM-yyyy");
        GetAll(_month);
        ValidateFields();
    }

    private void GetAll(int value)
    {
        var spendings = _budgetService.GetAll(value);
        var spendingsDto = spendings.Adapt<IEnumerable<DisplayBudgetToClient>>();
        dgvSpendings.DataSource = spendingsDto.ToList();
        dgvSpendings.Columns["CategoryName"]!.HeaderText = @"Category";
        dgvSpendings.Columns["SpendingDate"]!.HeaderText = @"Date";
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
        if (ValidateFields())
        {
            var budget = new BudGetEntity()
            {
                Description = txtDescription.Text,
                Amount = Convert.ToDecimal(txtAmount.Text),
                SpendingDate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()),
                IdCategory = cmbCategories?.SelectedValue?.ToString()
            };

            _budgetService.Create(budget);
            ClearFields();
        }
        else
        {
            MessageBox.Show("The fields cannot be empty, please verify.", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
      
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

    private void ClearFields()
    {
        txtDescription.Text = string.Empty;
        txtAmount.Text = string.Empty;
        txtDescription.Focus();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        CreateRecord();
        GetAll(_month);
    }

    private bool ValidateFields()
    {
        if (string.IsNullOrWhiteSpace(txtDescription.Text) || string.IsNullOrWhiteSpace(txtAmount.Text))
        {
            btnSave.Enabled = false;
            return false;
        }
        btnSave.Enabled = true;
        return true;
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

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        GetAll(_month);
        ClearFields();
    }
}