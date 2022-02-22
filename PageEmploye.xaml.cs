﻿using System;
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
    /// <summary>
    /// Логика взаимодействия для PageEmploye.xaml
    /// </summary>
    public partial class PageEmploye : Page
    {
        public static TitleEmployeEntities DataEntitiesEmploye { get; set; }
        ObservableCollection<Employe> ListEmploye;

        private bool isDirty = true;
        public PageEmploye()
        {
            InitializeComponent();
            DataEntitiesEmploye = new TitleEmployeEntities();
            ListEmploye = new ObservableCollection<Employe>();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
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

        private void UndoCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            isDirty = true;
        }

        private void UndoCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            MessageBox.Show("Отмена");
            e.CanExecute = isDirty;
        }

        private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Создать");
            isDirty = true;
        }
        private void NewCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void FindCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Найти");
            isDirty = true;
        }
        private void FindCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Удалить");
            isDirty = true;
        }
        private void DeleteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }
        private void EditCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }
        private void EditCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Редактировать");
            isDirty = true;
        }
        private void SaveCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }
        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Сохранение");
            isDirty = false;
        }
    }
}