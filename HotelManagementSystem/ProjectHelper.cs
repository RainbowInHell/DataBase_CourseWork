using Guna.UI2.WinForms;
using HotelManagementSystem.ControlScreens;
using HotelManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem
{
    public static class ProjectHelper
    {
        public static readonly string CONNECTION_STRING = "Server=127.0.0.1;Port=3306;Database=HotelDb;Uid=root;Pwd=matvey2003";
        public enum ScreenFlag { AdminHotelsViewScreenFlag, EmployeesScreenFlag, DepartmentsScreenFlag };

        #region WorkWithFieldsRegion

        public static bool AreAllTextBoxesFilled(params string[] values)
        {
            return !values.Any(x => string.IsNullOrEmpty(x));
        }

        public static bool AreAllTextBoxesFilled(Control.ControlCollection controlsToCheck)
        {
            foreach (Control c in controlsToCheck)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void ClearAllFields(Control.ControlCollection controlsToClear)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(controlsToClear);
        }

        #endregion


        #region WorkWithWindowsAndPanelsRegion

        public static void FillPanelWithWindow(Guna2Panel parentPanel, Form formToLoad, ScreenFlag screenFlag)
        {
            if (parentPanel.Controls.Count > 0)
                parentPanel.Controls.RemoveAt(0);

            switch (screenFlag)
            {
                case ScreenFlag.AdminHotelsViewScreenFlag:
                    formToLoad = formToLoad as AdminHotelsViewScreen;
                    break;

                case ScreenFlag.EmployeesScreenFlag:
                    formToLoad = formToLoad as EmployeesScreen;
                    break;
            }

            formToLoad.TopLevel = false;

            parentPanel.Controls.Add(formToLoad);

            formToLoad.FormBorderStyle = FormBorderStyle.None;
            formToLoad.Dock = DockStyle.Fill;
            formToLoad.Show();
        }

        public static bool DeleteButtonLogic(HotelDbContext _context, ScreenFlag screenFlag, string selectedHotelId = "", string selectedEntityId = "")
        {
            object entityToDelete = null;

            _context.ChangeTracker.Clear();

            switch (screenFlag)
            {
                case ScreenFlag.DepartmentsScreenFlag:
                    entityToDelete = _context.Departments.AsNoTracking().FirstOrDefault(dep => dep.DepartmentId == int.Parse(selectedEntityId));

                    if (entityToDelete == null) return false;

                    _context.Departments.Remove((Department)entityToDelete);
                    _context.SaveChanges();

                    return true;

                case ScreenFlag.AdminHotelsViewScreenFlag:
                    entityToDelete = _context.Hotels.AsNoTracking().FirstOrDefault(hot => hot.HotelId == int.Parse(selectedHotelId));

                    if (entityToDelete == null) return false;

                    _context.Hotels.Remove((Hotel)entityToDelete);
                    _context.SaveChanges();
                    _context.Hotels.Load();
                    return true;
            }

            return false;
        }

        public static void Refreshing(HotelDbContext _context, Guna2DataGridView _tabel)
        {
            _context = new HotelDbContext();
            _context.Departments.Load();
            BindingSource _bindingSource = new BindingSource();
            _bindingSource.DataSource = _context.Departments.Local.ToBindingList();

            _tabel.DataSource = _bindingSource;
            _tabel.Refresh();
        }

        #endregion
    }
}
