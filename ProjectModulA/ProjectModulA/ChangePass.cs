using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectModulA
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void ChengePassButton_Click(object sender, EventArgs e)
        {
            String oldPassword = oldPasswordFild.Text;
            String newPassword = newPasswordFild.Text;
            String loginUser = LoginFild.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE Username = @uL AND Password = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = oldPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MySqlCommand commandUpdate = new MySqlCommand("UPDATE `users` SET Password = @uP WHERE Username = @uL", db.GetConnection());
                commandUpdate.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                commandUpdate.Parameters.Add("@uP", MySqlDbType.VarChar).Value = newPassword;

                db.OpenConnection();

                if (commandUpdate.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы успешно ввели новый пароль");
                else
                    MessageBox.Show("Старый пароль или имя пользователя введены неверно");

                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("Старый пароль или имя пользователя введены неверно");
            }
        }
    }
}
