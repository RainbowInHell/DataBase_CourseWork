using Guna.UI2.WinForms;
using HotelManagementSystem.ControlScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace HotelManagementSystem
{
    public static class ProjectHelper
    {
        public enum ScreenFlag { AdminHotelsViewScreenFlag, EmployeesScreenFlag };

        #region WorkWithFieldsRegion

        public static bool AreAllTextBoxesFilled(params string[] values)
        {
            return values.Any(x => string.IsNullOrEmpty(x)) ? true : false;
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

        #endregion
    }
}
