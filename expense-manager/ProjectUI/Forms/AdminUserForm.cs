using Microsoft.EntityFrameworkCore;
using BusinessContext.Database;
using BusinessContext.Models;

namespace ProjectUI.Forms;

public partial class AdminUserForm : Form
{
    private readonly DatabaseContext _dbContext = new();
    private readonly BindingSource _bindingSource = new();

    public AdminUserForm()
    {
        InitializeComponent();
        InitializeGrid();
    }

    private void InitializeGrid()
    {
        UserGridView.AutoGenerateColumns = false;
        _dbContext.Users!.Load();
        _bindingSource.DataSource = _dbContext.Users!.Local.ToBindingList();
        UserGridView.DataSource = _bindingSource;
    }

    private void UserGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
        if (MessageBox.Show(@"Are you sure you want to delete this row?", @"Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            if (e.Row!.DataBoundItem is not User user) return;
            _dbContext.Users!.Remove(user);
            _dbContext.SaveChanges();
        }
        e.Cancel = true;
    }

    private void UserGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        var user = UserGridView.Rows[e.RowIndex].DataBoundItem as User;
        _dbContext.Entry(user).State = EntityState.Modified;
        _dbContext.SaveChanges();
    }
}
