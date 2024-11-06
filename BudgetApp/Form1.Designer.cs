namespace BudgetApp;

partial class BudgetApp
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        panel1 = new Panel();
        btnRefresh = new Button();
        groupBox1 = new GroupBox();
        btnFilter = new Button();
        cmbMonths = new ComboBox();
        lblCategory = new Label();
        cmbCategories = new ComboBox();
        btnSave = new Button();
        txtAmount = new MaskedTextBox();
        lblAmount = new Label();
        dateTimePicker1 = new DateTimePicker();
        lblDate = new Label();
        lblDescription = new Label();
        txtDescription = new TextBox();
        panelPrincipal = new Panel();
        groupBox2 = new GroupBox();
        lblTotalAmount = new Label();
        label1 = new Label();
        dgvSpendings = new DataGridView();
        panel1.SuspendLayout();
        groupBox1.SuspendLayout();
        panelPrincipal.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSpendings).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(118, 215, 196);
        panel1.Controls.Add(btnRefresh);
        panel1.Controls.Add(groupBox1);
        panel1.Controls.Add(lblCategory);
        panel1.Controls.Add(cmbCategories);
        panel1.Controls.Add(btnSave);
        panel1.Controls.Add(txtAmount);
        panel1.Controls.Add(lblAmount);
        panel1.Controls.Add(dateTimePicker1);
        panel1.Controls.Add(lblDate);
        panel1.Controls.Add(lblDescription);
        panel1.Controls.Add(txtDescription);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(294, 426);
        panel1.TabIndex = 0;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.FromArgb(247, 220, 111);
        btnRefresh.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnRefresh.ForeColor = Color.Black;
        btnRefresh.Location = new Point(186, 241);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(74, 42);
        btnRefresh.TabIndex = 11;
        btnRefresh.Text = "REFRESH";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnFilter);
        groupBox1.Controls.Add(cmbMonths);
        groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        groupBox1.Location = new Point(25, 297);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(235, 117);
        groupBox1.TabIndex = 10;
        groupBox1.TabStop = false;
        groupBox1.Text = "Filter by Month";
        // 
        // btnFilter
        // 
        btnFilter.BackColor = Color.FromArgb(34, 153, 84);
        btnFilter.FlatStyle = FlatStyle.Flat;
        btnFilter.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnFilter.ForeColor = Color.White;
        btnFilter.Location = new Point(18, 58);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new Size(192, 42);
        btnFilter.TabIndex = 10;
        btnFilter.Text = "SEARCH";
        btnFilter.UseVisualStyleBackColor = false;
        btnFilter.Click += btnFilter_Click;
        // 
        // cmbMonths
        // 
        cmbMonths.FormattingEnabled = true;
        cmbMonths.Location = new Point(18, 27);
        cmbMonths.Name = "cmbMonths";
        cmbMonths.Size = new Size(192, 22);
        cmbMonths.TabIndex = 9;
        cmbMonths.Text = "Seleccione una..";
        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblCategory.Location = new Point(28, 182);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new Size(56, 14);
        lblCategory.TabIndex = 9;
        lblCategory.Text = "Category";
        // 
        // cmbCategories
        // 
        cmbCategories.FormattingEnabled = true;
        cmbCategories.Location = new Point(26, 199);
        cmbCategories.Name = "cmbCategories";
        cmbCategories.Size = new Size(121, 23);
        cmbCategories.TabIndex = 8;
        cmbCategories.Text = "Seleccione una..";
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(52, 152, 219);
        btnSave.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(25, 241);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(155, 42);
        btnSave.TabIndex = 7;
        btnSave.Text = "SAVE";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // txtAmount
        // 
        txtAmount.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtAmount.Location = new Point(26, 148);
        txtAmount.Name = "txtAmount";
        txtAmount.Size = new Size(121, 23);
        txtAmount.TabIndex = 6;
        // 
        // lblAmount
        // 
        lblAmount.AutoSize = true;
        lblAmount.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblAmount.Location = new Point(25, 131);
        lblAmount.Name = "lblAmount";
        lblAmount.Size = new Size(51, 14);
        lblAmount.TabIndex = 5;
        lblAmount.Text = "Amount";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.CalendarFont = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dateTimePicker1.Location = new Point(25, 95);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(210, 23);
        dateTimePicker1.TabIndex = 3;
        // 
        // lblDate
        // 
        lblDate.AutoSize = true;
        lblDate.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblDate.Location = new Point(26, 78);
        lblDate.Name = "lblDate";
        lblDate.Size = new Size(88, 14);
        lblDate.TabIndex = 2;
        lblDate.Text = "Spending Date";
        // 
        // lblDescription
        // 
        lblDescription.AutoSize = true;
        lblDescription.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblDescription.Location = new Point(25, 24);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new Size(67, 14);
        lblDescription.TabIndex = 1;
        lblDescription.Text = "Description";
        // 
        // txtDescription
        // 
        txtDescription.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtDescription.Location = new Point(25, 42);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(210, 23);
        txtDescription.TabIndex = 0;
        txtDescription.TextChanged += txtDescription_TextChanged;
        // 
        // panelPrincipal
        // 
        panelPrincipal.BackColor = Color.FromArgb(52, 152, 219);
        panelPrincipal.Controls.Add(groupBox2);
        panelPrincipal.Controls.Add(dgvSpendings);
        panelPrincipal.Dock = DockStyle.Fill;
        panelPrincipal.Location = new Point(294, 0);
        panelPrincipal.Name = "panelPrincipal";
        panelPrincipal.Size = new Size(578, 426);
        panelPrincipal.TabIndex = 1;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(lblTotalAmount);
        groupBox2.Controls.Add(label1);
        groupBox2.Location = new Point(372, 352);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(194, 62);
        groupBox2.TabIndex = 3;
        groupBox2.TabStop = false;
        // 
        // lblTotalAmount
        // 
        lblTotalAmount.AutoSize = true;
        lblTotalAmount.FlatStyle = FlatStyle.Flat;
        lblTotalAmount.Font = new Font("3270Condensed NF", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTotalAmount.ForeColor = Color.White;
        lblTotalAmount.Location = new Point(90, 23);
        lblTotalAmount.Name = "lblTotalAmount";
        lblTotalAmount.Size = new Size(54, 24);
        lblTotalAmount.TabIndex = 4;
        lblTotalAmount.Text = "0.00";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(11, 23);
        label1.Name = "label1";
        label1.Size = new Size(73, 23);
        label1.TabIndex = 3;
        label1.Text = "TOTAL";
        // 
        // dgvSpendings
        // 
        dgvSpendings.AllowUserToAddRows = false;
        dgvSpendings.AllowUserToDeleteRows = false;
        dgvSpendings.AllowUserToResizeColumns = false;
        dgvSpendings.AllowUserToResizeRows = false;
        dgvSpendings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvSpendings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dgvSpendings.BackgroundColor = Color.White;
        dgvSpendings.BorderStyle = BorderStyle.None;
        dgvSpendings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(174, 214, 241);
        dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvSpendings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvSpendings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSpendings.Cursor = Cursors.Hand;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvSpendings.DefaultCellStyle = dataGridViewCellStyle2;
        dgvSpendings.Location = new Point(6, 42);
        dgvSpendings.Name = "dgvSpendings";
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle3.BackColor = SystemColors.Control;
        dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvSpendings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvSpendings.RowHeadersVisible = false;
        dgvSpendings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSpendings.Size = new Size(560, 304);
        dgvSpendings.TabIndex = 0;
        dgvSpendings.TabStop = false;
        // 
        // BudgetApp
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(872, 426);
        Controls.Add(panelPrincipal);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "BudgetApp";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Buget Application";
        Load += BudgetApp_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        groupBox1.ResumeLayout(false);
        panelPrincipal.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSpendings).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private DateTimePicker dateTimePicker1;
    private Label lblDate;
    private Label lblDescription;
    private TextBox txtDescription;
    private Label lblAmount;
    private MaskedTextBox txtAmount;
    private Panel panelPrincipal;
    private DataGridView dgvSpendings;
    private Button btnSave;
    private Label lblCategory;
    private ComboBox cmbCategories;
    private GroupBox groupBox1;
    private ComboBox cmbMonths;
    private Button btnFilter;
    private GroupBox groupBox2;
    private Label lblTotalAmount;
    private Label label1;
    private Button btnRefresh;
}