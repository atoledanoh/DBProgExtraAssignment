using System;
using System.Data;
using System.Windows.Forms;

namespace ExtraAssignment
{
    public class Utilities
    {
        public static void BindComboBox(ComboBox cmb, DataTable dt, string displayMember, string valueMember)
        {
            DataRow row = dt.NewRow();
            row[valueMember] = DBNull.Value;
            row[displayMember] = "";
            dt.Rows.InsertAt(row, 0);

            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.DataSource = dt;
        }
    }
}
