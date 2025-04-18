using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using static WindowsFormsApp1.AuthenticationService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly UserRole _currentUserRole;

        private object username;

        private void LoadExternalDll(string dllPath, string className, string methodName)
        {
            try
            {
                Assembly assembly = Assembly.LoadFrom(dllPath);
                Type type = assembly.GetType(className);
                object instance = Activator.CreateInstance(type);
                MethodInfo method = type.GetMethod(methodName);
                method.Invoke(instance, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки DLL: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Пример вызова обработчиков
        private void buttonLoadDll_Click(object sender, EventArgs e)
        {
            LoadExternalDll("MyPlugin.dll", "MyPlugin.Main", "Run");
        }
        public Form1(UserRole role, string username)
        {
            InitializeComponent();
            this.username = username;
            this.Text = $"Пользователь: {username}";
            _currentUserRole = role;
            ConfigureAccess();

            // Установка текста для элементов управления из библиотеки
            button1.Text = StringResources.Button1Text;
            разноеToolStripMenuItem.Text = StringResources.RaznoeToolStripMenuItemText;
            сотрудникиToolStripMenuItem.Text = StringResources.SotrudnikiToolStripMenuItemText;
            приказыToolStripMenuItem.Text = StringResources.PrikazyToolStripMenuItemText;
            документыToolStripMenuItem.Text = StringResources.DokumentyToolStripMenuItemText;
            справочникиToolStripMenuItem.Text = StringResources.SpravochnikiToolStripMenuItemText;
            отделыToolStripMenuItem.Text = StringResources.OtdelyToolStripMenuItemText;
            городаToolStripMenuItem.Text = StringResources.GorodaToolStripMenuItemText;
            должностиToolStripMenuItem.Text = StringResources.DolzhnostiToolStripMenuItemText;
            окноToolStripMenuItem.Text = StringResources.OknoToolStripMenuItemText;
            справкаToolStripMenuItem.Text = StringResources.SpravkaToolStripMenuItemText;
            оглавлениеToolStripMenuItem.Text = StringResources.OglavlenieToolStripMenuItemText;
            оПрограToolStripMenuItem.Text = StringResources.OPrograToolStripMenuItemText;

        }

        private void ConfigureAccess()
        {
            // Настройка видимости пунктов меню в зависимости от роли
            документыToolStripMenuItem.Visible = _currentUserRole == UserRole.Administrator;

            // Для root (Manager) закрываем доступ к документам
            if (_currentUserRole == UserRole.Manager)
            {
                документыToolStripMenuItem.Visible = false;
                приказыToolStripMenuItem.Visible = false;
            }

            // Для сотрудника ограничиваем доступ
            if (_currentUserRole == UserRole.Employee)
            {
                документыToolStripMenuItem.Visible = false;
                справочникиToolStripMenuItem.Visible = false;
                приказыToolStripMenuItem.Visible = false;
            }
        }
        private void разноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(StringResources.CompanyHistory);
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(StringResources.EmployeeStructure);
        }

        private void приказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(StringResources.HiringOrder);
        }

        private void документыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(StringResources.DocumentData);
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e) //в справонике 
        {
            MessageBox.Show(StringResources.DepartmentsInfo);
        }

        private void городаToolStripMenuItem_Click(object sender, EventArgs e)//в справонике 
        {
            MessageBox.Show(StringResources.CitiesInfo);
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)//в справонике 
        {
            MessageBox.Show(StringResources.PositionsInfo);
        }

        private void окноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(StringResources.WindowInfo);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оглавлениеToolStripMenuItem_Click(object sender, EventArgs e) //в справке
        {
            MessageBox.Show(StringResources.ContentsInfo);
        }

        private void оПрограToolStripMenuItem_Click(object sender, EventArgs e) //в спарвке
        {
            MessageBox.Show(StringResources.AboutProgramInfo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Close();
        }
    }
}
