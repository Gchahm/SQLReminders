using System;
using System.Windows.Forms;


namespace SQLReminders.Desktop.Forms
{
    public class AbstractFrame : Form
    {
        protected Form ChildForm;

        public AbstractFrame()
        {
        }

        protected virtual void RefreshList() { }

        protected int GetModelID(DataGridView dataGrid)
        {
            if (dataGrid.SelectedCells.Count > 0)
            {
                int rowIndex = dataGrid.CurrentCell.RowIndex;

                return Convert.ToInt32(dataGrid.Rows[rowIndex].Cells[0].Value);

            }
            throw new Exception("Please select a value");
        }

        protected void OpenFrame(Form form)
        {
            if (ChildClosed())
            {
                ChildForm = form;
                ChildForm.Show();
                ChildForm.BringToFront();
            }
            else
                form.Dispose();
        }

        protected bool ChildClosed()
        {
            if (ChildForm == null || ChildForm.IsDisposed)
                return true;
            ChildForm.BringToFront();
            MessageBox.Show("Close this form first");
            return false;
        }
    }
}
