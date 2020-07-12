using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using WPF_Infrostruktura_TK_test_task.Models;
using WPF_Infrostruktura_TK_test_task.View;

namespace WPF_Infrostruktura_TK_test_task.ViewModels
{
    class VariableViewModels : DependencyObject
    {

        public string FilterGroup
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterVariables.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterVariables", typeof(string), typeof(VariableViewModels), new PropertyMetadata("", FilterGroup_Changed));
        private static void FilterGroup_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is VariableViewModels current)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterVariables_by_Group;
            }
        }

        public string FilterName
        {
            get { return (string)GetValue(FilterNameProperty); }
            set { SetValue(FilterNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterNameProperty =
            DependencyProperty.Register("FilterName", typeof(string), typeof(VariableViewModels), new PropertyMetadata("", FilterName_Changed));

        private static void FilterName_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is VariableViewModels current)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterVariables_by_Name;
            }
        }

        public string FilterDescription
        {
            get { return (string)GetValue(FilterDescriptionProperty); }
            set { SetValue(FilterDescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterDescription.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterDescriptionProperty =
            DependencyProperty.Register("FilterDescription", typeof(string), typeof(VariableViewModels), new PropertyMetadata("", FilterDescription_Changed));

        private static CancellationTokenSource token_source;
        private static CancellationToken token;
        private static Task task_FilterDescription;
        private async static void FilterDescription_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var action_FilterDescription = new Action(() =>
                {
                    Thread.Sleep(300);//TODO эмпирическая задержка между нажатиями по клаве
                    d.Dispatcher.Invoke(() =>
                    {                       
                        if (d is VariableViewModels current)
                        {
                            if (token.IsCancellationRequested)
                            {
                                throw new OperationCanceledException(token);
                            }
                            else
                            {
                                current.Items.Filter = null;
                                current.Items.Filter = current.FilterVariables_by_Description;
                            }
                        }
                    }, DispatcherPriority.Normal);
                });

            if (token_source != null && task_FilterDescription != null && !task_FilterDescription.IsCompleted)
            {
                token_source.Cancel();//установим токен на отмену задачи
                try
                {
                    await task_FilterDescription;//передадим управление диспатчеру, и додемся отмены задачи
                }
                catch (TaskCanceledException)
                {
                    //задача была отменена
                }
                token_source = new CancellationTokenSource();//новый источник токенов
                token = token_source.Token;//новый токен
               
                task_FilterDescription = new Task(action_FilterDescription, token);
                task_FilterDescription.Start();
            }
            else//вызов был первый раз и токены еще не создавались или таски выполнились (сериализовано) друг за другом 
            {
                token_source = new CancellationTokenSource();//новый источник токенов
                token = token_source.Token;//новый токен

                task_FilterDescription = new Task(action_FilterDescription, token);
                task_FilterDescription.Start();
            }

        }

        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(VariableViewModels), new PropertyMetadata(null));

        public VariableViewModels()
        {
            Items = CollectionViewSource.GetDefaultView(Variable.GetVariables());
            Items.Filter = FilterVariables_by_Group;
        }
        private bool FilterVariables_by_Group(object obj)
        {
            //Убраны проверки на string.IsNullOrEmpty и   obj is Variable_with_group для оптимизации
            var current_var_with_gr = obj as Variable_with_group;
            return current_var_with_gr.Group.Contains(FilterGroup);
        }
        private bool FilterVariables_by_Name(object obj)
        {
            //Убраны проверки на string.IsNullOrEmpty и   obj is Variable_with_group для оптимизации
            var current_var_with_gr = obj as Variable_with_group;
            return current_var_with_gr.Name.Contains(FilterName);
        }
        private bool FilterVariables_by_Description(object obj)
        {
            //Убраны проверки на string.IsNullOrEmpty и   obj is Variable_with_group для оптимизации
            var current_var_with_gr = obj as Variable_with_group;
            return current_var_with_gr.Description.Contains(FilterDescription);
        }

        /// <summary>
        /// Поиск без учета регистра подстроки в строке
        /// </summary>
        /// <param name="source_str">исходная строка</param>
        /// <param name="pattern">подстрока</param>
        /// <returns></returns>
        private bool Contains_non_case_sensetive(string source_str, string pattern)
        {
            return source_str?.IndexOf(pattern, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
