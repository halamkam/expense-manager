using BusinessContext.Database;
using BusinessContext.Helpers;
using BusinessContext.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectUI.Forms;

public partial class HistoryForm : Form
{
    private readonly DatabaseContext _dbContext = new();
    private readonly BindingSource _bindingSource = new();

    public HistoryForm()
    {
        InitializeComponent();
        InitializeHistory();
    }

    private void InitializeHistory()
    {
        HistoryGridView.AutoGenerateColumns = false;
        if (TransactionHelper.CurrentUser!.Username == "root")  // admin rights
        {
            _dbContext.Transactions!.Load();
        }
        _dbContext.Transactions!.Where(t => t.Username == TransactionHelper.CurrentUser!.Username).Load();
        _bindingSource.DataSource = _dbContext.Transactions!.Local.ToBindingList();
        HistoryGridView.DataSource = _bindingSource;
    }

    private void HistoryGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
        if (MessageBox.Show(@"Are you sure you want to delete this row?", @"Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            if (e.Row!.DataBoundItem is Transaction transaction)
            {
                _dbContext.Transactions!.Remove(transaction);
                _dbContext.SaveChanges();
                e.Cancel = true;
            }
        }
        else
        {
            e.Cancel = true;
        }
    }

    private void HistoryGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        var transaction = HistoryGridView.Rows[e.RowIndex].DataBoundItem as Transaction;
        _dbContext.Entry(transaction).State = EntityState.Modified;
        _dbContext.SaveChanges();
    }
}