using Guna.UI2.WinForms;
using HotelManagementSystem.ControlScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public static class ProjectHelper
    {
        public enum ScreenFlag { AdminHotelsViewScreenFlag, EmployeesScreenFlag };

        #region FieldsVerifyRegion

        public static bool IsAnyOfFieldsNullOrEmpty(params string[] values)
        {
            return values.Any(x => string.IsNullOrEmpty(x)) ? true : false;
        }

        #endregion


        #region WorkWithWindowsAndPanelsRegion

        public static void FillPanelWithWindow(Guna2Panel parentPanel, Form formToLoad, ScreenFlag screenFlag)
        {
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
