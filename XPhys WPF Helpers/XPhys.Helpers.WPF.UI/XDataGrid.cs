using System;
using System.ComponentModel;
using System.Reflection;

namespace XPhys.Helpers.WPF.UI
{
    /// <summary>
    /// WPF DataGrid Helpers
    /// </summary>
    public class XDataGrid
    {
        /// <summary>
        /// DESCRIPTION: Get name from System.ComponentModel.DisplayNameAttribute.DisplayName 
        /// PURPOSE: Automatically generate column name based on DisplayName() decoration set in data-model class
        /// REFERENCE: http://stackoverflow.com/questions/13579034/how-do-you-rename-datagrid-columns-when-autogeneratecolumns-true
        /// HOW TO USE : place it in 'AutoGeneratingColumn()' of DataGrid
        /// ==========================================================================================
        /// void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        /// {
        ///     var displayName = GetPropertyDisplayName(e.PropertyDescriptor);
        ///     if (!string.IsNullOrEmpty(displayName)) e.Column.Header = displayName;
        /// }
        /// ==========================================================================================
        /// </summary>
        /// <param name="descriptor"></param>
        /// <returns></returns>
        public static string GetPropertyDisplayName(object descriptor)
        {
            var pd = descriptor as PropertyDescriptor;

            if (pd != null)
            {
                // Check for DisplayName attribute and set the column header accordingly
                var displayName = pd.Attributes[typeof(DisplayNameAttribute)] as DisplayNameAttribute;

                if (displayName != null && displayName != DisplayNameAttribute.Default)
                {
                    return displayName.DisplayName;
                }

            }
            else
            {
                var pi = descriptor as PropertyInfo;

                if (pi != null)
                {
                    // Check for DisplayName attribute and set the column header accordingly
                    Object[] attributes = pi.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                    for (int i = 0; i < attributes.Length; ++i)
                    {
                        var displayName = attributes[i] as DisplayNameAttribute;
                        if (displayName != null && displayName != DisplayNameAttribute.Default)
                        {
                            return displayName.DisplayName;
                        }
                    }
                }
            }

            return null;
        }

    }
}
