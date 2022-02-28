using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    public partial class PageEmploye : Page
    {
        public static TitleEmployeEntities DataEntitiesEmploye { get; set; }
        ObservableCollection<Employe> ListEmploye;

        private bool isDirty = true;
        public PageEmploye()
        {
            DataEntitiesEmploye = new TitleEmployeEntities();
            ListEmploye = new ObservableCollection<Employe>();
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GetEmploye();
            DataGridEmpoyee.SelectedIndex = 0;
        }

        private void GetEmploye()
        {
            var employees = DataEntitiesEmploye.Employes;
            var queryEmploye = from employee in employees
                               orderby employee.Surname
                               select employee;

            foreach (Employe employe in queryEmploye)
            {
                ListEmploye.Add(employe);
            }
            DataGridEmpoyee.ItemsSource = ListEmploye;
        }

        private void RewriteEmploye()
        {
            DataEntitiesEmploye = new TitleEmployeEntities();
            ListEmploye.Clear();
            GetEmploye();
        }

        private void UndoCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RewriteEmploye();
            DataGridEmpoyee.IsReadOnly = true;
            isDirty = true;
        }

        private void UndoCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void FindCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            BorderFind.Visibility = System.Windows.Visibility.Visible;
        }
        private void FindCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Employe emp = DataGridEmpoyee.SelectedItem as Employe;
            if (emp != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить сотрудника: " +
                                                          emp.Surname.Trim() + " " + 
                                                          emp.Name.Trim() + " " +
                                                          emp.Patronymic.Trim() + "?", 
                                                          "Внимание", 
                                                          MessageBoxButton.OKCancel);
                
                if (result == MessageBoxResult.OK)
                {
                    DataEntitiesEmploye.Employes.Remove(emp);
                    DataGridEmpoyee.SelectedIndex = DataGridEmpoyee.SelectedIndex == 0 ? 1 : DataGridEmpoyee.SelectedIndex - 1;
                    ListEmploye.Remove(emp);
                    DataEntitiesEmploye.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Выбери строку");
            }
        }

        private void DeleteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }

        private void EditCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void EditCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Войти в режим редактирования?", 
                                                      "Внимание!", 
                                                      MessageBoxButton.YesNo, 
                                                      MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                isDirty = false;
            }  
        }

        private void SaveCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }

        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                DataEntitiesEmploye.SaveChanges();
                DataGridEmpoyee.IsReadOnly = true;
                MessageBox.Show("Сохранено!", "Сохранение" ,MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка сохранения", "Ошибка!",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }

            isDirty = true;
        }

        private void AddCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }

        private void AddCommandBinding_executed(object sender, ExecutedRoutedEventArgs e)
        {
            Employe emp = Employe.createEmploye(-1, "Не задано", "Не задано", 
                                                "Не задано", 0);

            try
            {
                DataEntitiesEmploye.Employes.Add(emp);
                ListEmploye.Add(emp);
                DataGridEmpoyee.ScrollIntoView(emp);
                DataGridEmpoyee.SelectedIndex = DataGridEmpoyee.Items.Count - 1;
                DataGridEmpoyee.Focus();
                DataGridEmpoyee.IsReadOnly = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TextBoxSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            ButtonFindSurname.IsEnabled = true;
            ButtonFindTitle.IsEnabled = true;
            ComboBoxTitle.SelectedIndex = -1;
        }

        private void ButtonFindSurname_Click(object sender, RoutedEventArgs e)
        {
            string surname = TextBoxSurname.Text;
            DataEntitiesEmploye = new TitleEmployeEntities();
            ListEmploye.Clear();

            var employes = DataEntitiesEmploye.Employes;
            var queryEmploye = from employe in employes
                               where employe.Surname == surname
                               select employe;
            foreach (Employe emp in queryEmploye)
            {
                ListEmploye.Add(emp);
            }

            if (ListEmploye.Count > 0)
            {
                DataGridEmpoyee.ItemsSource = ListEmploye;
                ButtonFindSurname.IsEnabled = true;
                ButtonFindTitle.IsEnabled = false;
            }
            else
                MessageBox.Show("Сотрудник с фамилией '" + surname + "' не найден",
                                "Внимание!", MessageBoxButton.OK, 
                                MessageBoxImage.Warning);
        }

        private void ComboBoxTitle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonFindTitle.IsEnabled = true;
            ButtonFindSurname.IsEnabled = false;
            TextBoxSurname.Text = "";
        }

        private void ButtonFindTitle_Click(object sender, RoutedEventArgs e)
        {
            DataEntitiesEmploye = new TitleEmployeEntities();
            ListEmploye.Clear();

            Title title = ComboBoxTitle.SelectedItem as Title;
            var employes = DataEntitiesEmploye.Employes;
            var queryEmploye = from employe in employes
                               where employe.TitleID == title.ID
                               orderby employe.Surname
                               select employe;
            foreach (Employe emp in queryEmploye)
            {
                ListEmploye.Add(emp);
            }
            DataGridEmpoyee.ItemsSource = ListEmploye;
        }

        private void RefreshCommandBinding_Executed(object sender, RoutedEventArgs e)
        {
            RewriteEmploye();
            DataGridEmpoyee.IsReadOnly = false;
            isDirty = true;
            BorderFind.Visibility = Visibility.Hidden;
        }
    }
}
